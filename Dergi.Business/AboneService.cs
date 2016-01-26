using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dergi.Business.Uow;
using Dergi.Business.ViewModel;
using Dergi.Model;

namespace Dergi.Business
{
    public class AboneService : IService
    {
        private static AboneService _instance;
        public static AboneService Instance
        {
            get { return _instance ?? (_instance = new AboneService()); }
        }

        public void GetAbone()
        {

        }

        public AboneHesapMasterViewModel GetAboneHesapList(int aboneId)
        {
            var model = new AboneHesapMasterViewModel();
            Mapper.CreateMap<AboneHesap, AboneHesapViewModel>();
            model.AboneHesapViewModels =
                UnitOfWork.Instance.GetRepository<AboneHesap>()
                    .Filter(x => x.AboneId == aboneId)
                    .ProjectTo<AboneHesapViewModel>()
                    .AsEnumerable()
                    .ToList();
            model.Balance =
                model.AboneHesapViewModels.Where(x => x.IslemType == Model.Util.IslemType.Borç)
                    .Select(x => x.Amount)
                    .Sum() -
                model.AboneHesapViewModels.Where(x => x.IslemType == Model.Util.IslemType.Alınan)
                    .Select(x => x.Amount)
                    .Sum();
            return model;
        }

        public void AboneInsert(Abone abone)
        {
            UnitOfWork.Instance.GetRepository<Abone>().Create(abone);
            var aboneHesap = new AboneHesap
            {
                AboneId = abone.Id,
                Amount = abone.AboneType.Amount,
                Description = "Abonelik Bedeli",
                IslemDate = DateTime.Now,
                IslemType = Model.Util.IslemType.Borç
            };
            UnitOfWork.Instance.GetRepository<AboneHesap>().Create(aboneHesap);
            UnitOfWork.Instance.Save();
        }

        public List<AboneDergiViewModel> GetAboneDergiList(int aboneId)
        {
            Mapper.CreateMap<AboneDergi, AboneDergiViewModel>();
            return UnitOfWork.Instance.GetRepository<AboneDergi>()
                    .Filter(x => x.AboneId == aboneId)
                    .ProjectTo<AboneDergiViewModel>()
                    .AsEnumerable()
                    .ToList();
        }
    }
}