﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class NumericProperty:AbstractProperty
    {
        public NumericProperty(Double numeric, string name)
        {
            DataValue = numeric;
            Name = name;
        }
    }
}
