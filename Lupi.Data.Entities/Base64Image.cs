﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Base64Image
    {
        public Guid Id { get; set; }
        public string Base64EncodedImage { get; set; }
    }
}
