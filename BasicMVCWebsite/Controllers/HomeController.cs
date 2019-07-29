using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicMVCWebsite.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using GoogleMaps.LocationServices;

namespace BasicMVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public string FirstName { get; set; }
        static HttpClient client = new HttpClient();
        private ITemperatureUnit temperature;
        private ICity city;

        public HomeController(ITemperatureUnit temperatureUnit,ICity _city)
        {
            temperature = temperatureUnit;
            city = _city;
            if(city.Lat.Equals("0") && city.Lon.Equals("0"))
            {
                city.setDefault();
            }
        }

        public IActionResult ChangeCity(string input)
        {
            var weather = new weather();
            var locationService = new GoogleLocationService("AIzaSyDt0Pu9RDpmvBla4hsY5Fqm5IFEZx1kGF4");
            try
            {
                var point = locationService.GetLatLongFromAddress(input);
                city.Lon = point.Latitude.ToString();
                city.Lat = point.Longitude.ToString();
                city.City = input + "(" + city.Lon + " , " + city.Lat + ")"; ;

            }
            catch (Exception e)
            {
                weather.currentTime = weather.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
                city.setDefault();
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Index()
        {
            var weather= new weather();
            weather.currentTime = weather.FormateDate(DateTimeOffset.UtcNow.TimeOfDay);
            await GetWeatherAsync(weather);
            weather.city = city.City;
            return View(weather);
        }
        [HttpPost]
        public async Task<IActionResult> toggleFahrenheit()
        {
            temperature.toggleFahrenheit();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> toggleCelsius()
        {
            temperature.toggleCelsius();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> toggleUnit()
        {
            temperature.toggleTemperatureUnit();
            return RedirectToAction("Index", "Home");
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
