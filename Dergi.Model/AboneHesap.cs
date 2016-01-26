using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class AboneHesap : BaseEntity
    {
        public int AboneId { get; set; }
        public virtual Abone Abone { get; set; }
        public Util.IslemType IslemType  { get; set; }
        public DateTime IslemDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
