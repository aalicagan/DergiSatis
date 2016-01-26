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
    public class TahakkukService : IService
    {
        private static TahakkukService _instance;
        public static TahakkukService Instance
        {
            get { return _instance ?? (_instance = new TahakkukService()); }
        }

        public void DoTakukkukProcess(TahakkukViewModel tahakkukViewModel)
        {
            if (tahakkukViewModel.IsAllAbone)
            {
                foreach (var abone in UnitOfWork.Instance.GetRepository<Abone>().SelectAll())
                {
                    if (abone.Count >= abone.AboneType.DergiCount) continue;
                    if (UnitOfWork.Instance.GetRepository<AboneDergi>().Filter(x => x.AboneId == abone.Id && x.DergiId == tahakkukViewModel.DergiId).Any()) continue;
                    var aboneDergi = new AboneDergi();
                    aboneDergi.AboneId = abone.Id;
                    aboneDergi.DergiId = tahakkukViewModel.DergiId;
                    aboneDergi.IsDelivered = false;
                    aboneDergi.IslemDate = DateTime.Now;
                    UnitOfWork.Instance.GetRepository<AboneDergi>().Create(aboneDergi);
                    abone.LastDergiId = tahakkukViewModel.DergiId;
                    abone.Count++;
                    UnitOfWork.Instance.Save();
                }
                return;
            }
            if (tahakkukViewModel.AboneId <= 0)
                throw new Exception("En az bir abone seçin");
            if (UnitOfWork.Instance.GetRepository<AboneDergi>().Filter(x => x.AboneId == tahakkukViewModel.AboneId && x.DergiId == tahakkukViewModel.DergiId).Any())
                throw new Exception("Bu aboneye daha önce seçilen dergi tahakkuk edilmiş.");
            var model = new AboneDergi();
            model.AboneId = tahakkukViewModel.AboneId;
            model.DergiId = tahakkukViewModel.DergiId;
            model.IsDelivered = false;
            model.IslemDate = DateTime.Now;
            UnitOfWork.Instance.GetRepository<AboneDergi>().Create(model);
            var aboneModel =
                UnitOfWork.Instance.GetRepository<Abone>()
                    .Filter(x => x.Id == tahakkukViewModel.AboneId)
                    .FirstOrDefault();
            aboneModel.LastDergiId = tahakkukViewModel.DergiId;
            aboneModel.Count++;
            UnitOfWork.Instance.Save();
        }
    }
}