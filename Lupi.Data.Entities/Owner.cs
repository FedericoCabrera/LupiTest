using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lupi.Data.Entities
{
    public class Owner
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Collar> Collars { get; set; }
    }
}
