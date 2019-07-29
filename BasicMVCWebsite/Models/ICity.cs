using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCWebsite.Models
{
    public interface ICity
    {
                 string Lat { get; set; }
                 string Lon { get; set; }
                    string City { get; set; }
        void setDefault();
    }
}
