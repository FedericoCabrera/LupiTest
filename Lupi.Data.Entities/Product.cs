using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

    }
}
