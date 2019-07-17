using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVCWebsite.Models
{
    public class TemperatureUnit : ITemperatureUnit
    {
        private string _temperatureUnit = "Fahrenheit";
        public string temperatureUnit { get { return _temperatureUnit; } set { _temperatureUnit = value;} }

        public string getTemperatureUnit() //ok this isnt the best way to do this but it makes sense to me for rn so leave it
        {
            return temperatureUnit;
        }

        public bool isCelsius()
        {
           if(string.Equals(temperatureUnit,"Celsius"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isFahrenheit()
        {
            if (string.Equals(temperatureUnit, "Fahrenheit"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void toggleCelsius()
        {
            temperatureUnit = "Celsius";
        }

        public void toggleFahrenheit()
        {
            temperatureUnit = "Fahrenheit";
        }

        public void toggleTemperatureUnit()
        {
            if(string.Equals(temperatureUnit,"Fahrenheit"))
            {
                temperatureUnit = "Celsius";
            }else if(string.Equals(temperatureUnit,"Celsius"))
            {
                temperatureUnit = "Fahrenheit";
            }
        }
    }
}
