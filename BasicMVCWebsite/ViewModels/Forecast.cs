using BasicMVCWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BasicMVCWebsite.ViewModels
{
    public class Forecast
    {
        public string Id;
        public List<weather> SixteenDayForecast;
        public weather getDetailedForecastByDay(int date)
        {
            foreach(var day in SixteenDayForecast)
            {
                if(day.id == date)
                {
                    return day;
                }
            }
            return null;
        }
    }


}
