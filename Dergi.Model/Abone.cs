using System;
using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class Abone : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Util.StatusType Status { get; set; }
        public int BirimId { get; set; }
        public virtual Birim Birim { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int  FirstDergiId { get; set; }
        public int LastDergiId { get; set; }

        public int AboneTypeId { get; set; }
        public virtual AboneType AboneType { get; set; }
    }
}
