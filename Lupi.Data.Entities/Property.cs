using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class AbstractProperty
    {
        private Type dataType;
        public Type DataType {
            get
            {
                return dataType;
            }
        }
        public string Name { get; set; }

        private object dataValue;
        public object DataValue {
            get
            {
                return dataValue;
            }
            set
            {
                dataValue = value;
                dataType = value.GetType();
            }
        }

    }
}
