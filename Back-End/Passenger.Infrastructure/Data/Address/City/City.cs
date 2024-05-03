﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }

    }
}
