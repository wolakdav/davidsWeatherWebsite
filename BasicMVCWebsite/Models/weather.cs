using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasicMVCWebsite.Models
{
    public class weather
    {
      

        public weather()
        {
            city = "Portland";
        }

        public weather(JToken dayForecast)
        {
            city = "Portland";
            System.DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            Time = (long)dayForecast["time"];
            Summary = (string)dayForecast["summary"];
            Icon = (string)dayForecast["icon"];
            SunriseTime = (dateTime.AddSeconds((double)dayForecast["sunriseTime"])).ToString("hh:mm tt");
            SunsetTime = (dateTime.AddSeconds((double)dayForecast["sunsetTime"])).ToString("hh:mm tt");
            MoonPhase = (double)dayForecast["moonPhase"];
            PrecipIntensity = (double)dayForecast["precipIntensity"];
            PrecipIntensityMax = (double)dayForecast["precipIntensityMax"];
            PrecipIntensityMaxTime = (dateTime.AddSeconds((double)dayForecast["precipIntensityMaxTime"])).ToString("hh:mm tt"); ;
            PrecipProbability = (long)dayForecast["precipProbability"];
            PrecipType = (string)dayForecast["precipType"];
            TemperatureHigh = (long)dayForecast["temperatureHigh"];
            TemperatureHighTime = (dateTime.AddSeconds((double)dayForecast["temperatureHighTime"])).ToString("hh:mm tt"); ;
            TemperatureLow = (long)dayForecast["temperatureLow"];
            TemperatureLowTime = (dateTime.AddSeconds((double)dayForecast["temperatureLowTime"])).ToString("hh:mm tt"); ;
            ApparentTemperatureHigh = (long)dayForecast["apparentTemperatureHigh"];
            ApparentTemperatureHighTime = (dateTime.AddSeconds((double)dayForecast["apparentTemperatureHighTime"])).ToString("hh:mm tt"); ;
            ApparentTemperatureLow = (long)dayForecast["apparentTemperatureLow"];
            ApparentTemperatureLowTime = (dateTime.AddSeconds((double)dayForecast["apparentTemperatureLowTime"])).ToString("hh:mm tt"); ;
            DewPoint = (long)dayForecast["dewPoint"];
            Humidity = (long)dayForecast["humidity"];
            Pressure = (long)dayForecast["pressure"];
            WindSpeed = (long)dayForecast["windSpeed"];
            WindGust = (long)dayForecast["windGust"];
            WindGustTime = (dateTime.AddSeconds((double)dayForecast["windGustTime"])).ToString("hh:mm tt"); ;
            WindBearing = (long)dayForecast["windBearing"];
            CloudCover = (long)dayForecast["cloudCover"];
            UvIndex = (long)dayForecast["uvIndex"];
            UvIndexTime = (dateTime.AddSeconds((double)dayForecast["uvIndexTime"])).ToString("hh:mm tt"); ;
            Visibility = (long)dayForecast["visibility"];
            Ozone = (long)dayForecast["ozone"];
            TemperatureMin = (long)dayForecast["temperatureMin"];
            TemperatureMinTime = (dateTime.AddSeconds((double)dayForecast["temperatureMinTime"])).ToString("hh:mm tt"); ;
            TemperatureMax = (long)dayForecast["temperatureMax"];
            TemperatureMaxTime = (dateTime.AddSeconds((double)dayForecast["temperatureMaxTime"])).ToString("hh:mm tt"); ;
            ApparentTemperatureMin = (long)dayForecast["apparentTemperatureMin"];
            ApparentTemperatureMinTime = (dateTime.AddSeconds((double)dayForecast["apparentTemperatureMinTime"])).ToString("hh:mm tt"); ;
            ApparentTemperatureMax = (long)dayForecast["apparentTemperatureMax"];
            ApparentTemperatureMaxTime = (dateTime.AddSeconds((double)dayForecast["apparentTemperatureMaxTime"])).ToString("hh:mm tt"); ;
        }

        public string city { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; }

        public string currentTime { get; set; }
        public int id { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        public double temperature { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("sunriseTime")]
        public string SunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public string SunsetTime { get; set; }

        [JsonProperty("moonPhase")]
        public double MoonPhase { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [JsonProperty("precipIntensityMaxTime")]
        public string PrecipIntensityMaxTime { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        [JsonProperty("temperatureHigh")]
        public double TemperatureHigh { get; set; }

        [JsonProperty("temperatureHighTime")]
        public string TemperatureHighTime { get; set; }

        [JsonProperty("temperatureLow")]
        public double TemperatureLow { get; set; }

        [JsonProperty("temperatureLowTime")]
        public string TemperatureLowTime { get; set; }

        [JsonProperty("apparentTemperatureHigh")]
        public double ApparentTemperatureHigh { get; set; }

        [JsonProperty("apparentTemperatureHighTime")]
        public string ApparentTemperatureHighTime { get; set; }

        [JsonProperty("apparentTemperatureLow")]
        public double ApparentTemperatureLow { get; set; }

        [JsonProperty("apparentTemperatureLowTime")]
        public string ApparentTemperatureLowTime { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windGustTime")]
        public string WindGustTime { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("uvIndexTime")]
        public string UvIndexTime { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temperatureMinTime")]
        public string TemperatureMinTime { get; set; }

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("temperatureMaxTime")]
        public string TemperatureMaxTime { get; set; }

        [JsonProperty("apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        [JsonProperty("apparentTemperatureMinTime")]
        public string ApparentTemperatureMinTime { get; set; }

        [JsonProperty("apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        [JsonProperty("apparentTemperatureMaxTime")]
        public string ApparentTemperatureMaxTime { get; set; }


        public string FormateDate(TimeSpan currentTime)
        {
            var hours = currentTime.Hours % 12;
            return string.Format("{0}:{1}:{2}", hours, currentTime.Minutes, currentTime.Seconds);
        }
           
    }
}
