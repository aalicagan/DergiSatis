using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dergi.Model.Repo;

namespace Dergi.Model
{
    public class Dergi : BaseEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
    }
}
