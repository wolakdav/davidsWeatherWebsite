﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCWebsite.Models
{
    public class CityModel : ICity
    {
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
