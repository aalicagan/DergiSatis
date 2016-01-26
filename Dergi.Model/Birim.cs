using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class Birim:BaseEntity
    {
        public string Name { get; set; }
        public Util.StatusType Status { get; set; }

        public int BolgeId { get; set; }
        public virtual Bolge Bolge { get; set; }

        public int BirimTurId { get; set; }
        public virtual BirimTur BirimTur { get; set; }
    }
}
