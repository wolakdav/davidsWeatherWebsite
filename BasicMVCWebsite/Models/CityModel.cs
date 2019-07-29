using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCWebsite.Models
{
    public class CityModel : ICity
    {
        public CityModel()
        {
            City = null;
            Lat = "0";
            Lon = "0";
        }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string City { get; set; }

        public void setDefault()
        {
            City = "Portland";
            Lat = "-122";
            Lon = "45";
        }
    }
}
