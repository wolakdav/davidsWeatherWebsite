using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCWebsite.Models
{
    public interface ITemperatureUnit
    {
        string temperatureUnit { get; set; }
        string getTemperatureUnit();
        void toggleTemperatureUnit();
        bool isFahrenheit();
        bool isCelsius();

        void toggleFahrenheit();
        void toggleCelsius();
    }
}
