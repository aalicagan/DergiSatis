using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class AboneType : BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int DergiCount { get; set; }
        public bool IsFree { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
