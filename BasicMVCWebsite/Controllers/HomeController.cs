using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicMVCWebsite.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace BasicMVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public string FirstName { get; set; }
        static HttpClient client = new HttpClient();
        private ITemperatureUnit temperature;
        private ICity city;
        private string LAT = "45";
        private string LON = "-122";
        public HomeController(ITemperatureUnit temperatureUnit,ICity _city)
        {
            temperature = temperatureUnit;
            city = _city;
            city.Lat = "-122";
            city.Lon = "45";
        }

        public async Task<IActionResult> ChangeCityAsync(string input)
        {
            string[] Lat_Lon = input.Split();
            city.Lat = Lat_Lon[0];
            city.Lon = Lat_Lon[1];
            var weather = new weather();
            weather.city = input;
            await GetWeatherAsync(weather);
            return View("Index",weather);
        }
        public async Task<IActionResult> Index()
        {
            var view = new weather();
            view.currentTime = view.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
            await GetWeatherAsync(view);
            return View(view);
        }
        [HttpPost]
        public async Task<IActionResult> toggleFahrenheit()
        {
            temperature.toggleFahrenheit();
             var weather = new weather();
             weather.currentTime = weather.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
             await GetWeatherAsync(weather);
             return View("Index", weather);
        }

        [HttpPost]
        public async Task<IActionResult> toggleCelsius()
        {
            temperature.toggleCelsius();
            var weather = new weather();
            weather.currentTime = weather.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
            await GetWeatherAsync(weather);
            return View("Index", weather);
        }

        [HttpPost]
        public async Task<IActionResult> toggleUnit()
        {
            temperature.toggleTemperatureUnit();
            ViewBag.otherUnit = "C";
            var weather = new weather();
            weather.currentTime = weather.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
            await GetWeatherAsync(weather);
            return View("Index", weather);
        }


        private async Task<string> GetWeatherAsync(weather weather )
        {
            var APIKEY = "695544473a2dd8009951c9bddec71282";
            string Lat = city.Lat;
            string Lon = city.Lon;
            string request = $"https://api.darksky.net/forecast/{APIKEY}/{Lon},{Lat}";
            HttpResponseMessage response = await client.GetAsync(request);
            string content = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(content);
            weather.Summary = (string)json["currently"]["summary"];
            if (temperature.isFahrenheit())
            {
                weather.TemperatureHigh  = (Math.Round((double)json["daily"]["data"][0]["temperatureHigh"]));
                weather.TemperatureLow  = (Math.Round((double)json["daily"]["data"][0]["temperatureLow"]));
                weather.temperature = (Math.Round((double)json["currently"]["temperature"]));
            }
            else if(temperature.isCelsius())
            {
                weather.TemperatureHigh  = FahrenheitToCelsius((double)json["daily"]["data"][0]["temperatureHigh"]);
                weather.TemperatureLow  = FahrenheitToCelsius((double)json["daily"]["data"][0]["temperatureLow"]);
                weather.temperature = FahrenheitToCelsius((double)json["currently"]["temperature"]);
            }
            return "ok";
        }

        private double FahrenheitToCelsius(double temperture)
        {
            return (Math.Round((temperture - 32) * (5.0 / 9.0)));
        }
    }
}
