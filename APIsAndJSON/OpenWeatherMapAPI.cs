using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void PhillyTemp()
        {
            //var key = "bcbcabeea971ba9430a7d0c2ec63cd36";
            //var city = "Philadelphia";
            var client = new HttpClient();
            var weatherURL = "https://api.openweathermap.org/data/2.5/forecast?q=Philadelphia&units=imperial&appid=bcbcabeea971ba9430a7d0c2ec63cd36";
            var jsonResponse = client.GetStringAsync(weatherURL).Result;
            JObject formattedResponse = JObject.Parse(jsonResponse);
            var temp = formattedResponse["list"][0]["main"]["temp"];
            Console.WriteLine(temp);
        }
       
    }
}
