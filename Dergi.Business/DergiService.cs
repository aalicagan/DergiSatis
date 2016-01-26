using System.Collections.Generic;
using System.Linq;
using Dergi.Business.Uow;

namespace Dergi.Business
{
    public class DergiService:IService
    {
        private static DergiService _instance;
        public static DergiService Instance
        {
            get { return _instance ?? (_instance = new DergiService()); }
        }

        public List<Model.Dergi> GetAllList()
        {
            return UnitOfWork.Instance.GetRepository<Model.Dergi>().SelectAll().ToList();
        }
    }
}