using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BasicMVCWebsite.Models;
using BasicMVCWebsite.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicMVCWebsite.Controllers
{
    public class ForecastController : Controller
    {
        static HttpClient client = new HttpClient();
        private Forecast forecast = new Forecast();
        private ICity city;
        private ITemperatureUnit temperatureUnit;
        // GET: /<controller>/
        public ForecastController(ICity _city, ITemperatureUnit temperature)
        { 
            temperatureUnit = temperature;
            city = _city;
        }
        public async Task<IActionResult> Index()
        {
            forecast.SixteenDayForecast = await get16DayForecastAsync();
            return View(forecast);
        }

        public async Task<IActionResult> detailedForecast(int id)
        {
            var detailedWeather = new weather();
            forecast.SixteenDayForecast = await get16DayForecastAsync();//todo make this persistant
            detailedWeather = forecast.getDetailedForecastByDay(id);
            if(detailedWeather == null)
            {
                return NotFound();
            }
            return View(detailedWeather);
        }

        private async Task<List<weather>> get16DayForecastAsync()
        {
            var APIKEY = "695544473a2dd8009951c9bddec71282";
            String request = $"https://api.darksky.net/forecast/{APIKEY}/{city.Lon},{city.Lat}";
            HttpResponseMessage response = await client.GetAsync(request);
            string content = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(content);

            var forecast = new List<weather>();
            var id = 0;
            foreach(var dayForecast in json["daily"]["data"])
            {
             
                    weather weather = new weather(dayForecast);

                if (temperatureUnit.isFahrenheit())
                {
                    
                    weather.TemperatureHigh = Math.Round((double)dayForecast["temperatureHigh"]);
                    weather.TemperatureLow  = Math.Round((double)dayForecast["temperatureLow"]);
                }
                else if (temperatureUnit.isCelsius())
                {
                    weather.TemperatureHigh = FahrenheitToCelsius((double)dayForecast["temperatureHigh"]);
                    weather.TemperatureLow  = FahrenheitToCelsius((double)dayForecast["temperatureLow"]);
                }
                    weather.Summary = (string)dayForecast["summary"];
                    weather.currentTime = GetDateFromUnixTimestamp((double)dayForecast["time"]).ToString();
                weather.id = 0;
                id++;
                    forecast.Add(weather);
            }
            return forecast;
        }

        private double FahrenheitToCelsius(double temperture)
        {
            return (Math.Round((temperture - 32) * (5.0 / 9.0)));
        }
        private string GetDateFromUnixTimestamp(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            string[] dateTime = (dtDateTime.ToString()).Split();
            return dateTime[0];
        }
        private string KelvinToFahrenheit(double temperature)
        {
            temperature = (temperature - 273.15) * (9 / 5) + 32;
            return temperature.ToString();
        }

        private string KelvinToCelsius(double temperature)
        {
            return (temperature - 273.15).ToString();
        }
    }
}
