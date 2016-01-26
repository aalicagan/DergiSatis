using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class AboneDergi : BaseEntity
    {
        public int AboneId { get; set; }
        public virtual Abone Abone { get; set; }
        public int DergiId { get; set; }
        public virtual Dergi Dergi { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime IslemDate { get; set; }
    }
}
