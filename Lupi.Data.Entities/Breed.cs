using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Breed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HairType { get; set; }
        public List<string> HairColors { get; set; }

    }
}
