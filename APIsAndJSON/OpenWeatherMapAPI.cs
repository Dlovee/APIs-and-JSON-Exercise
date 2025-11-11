using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private readonly HttpClient client = new HttpClient();

        public string Weather()
        {
            var key = "0112365684344e33e833e9b91442534d";
            var city = "Houston";
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";

            var response = client.GetStringAsync(weatherUrl).Result;
            var weatherData = JObject.Parse(response);
            return weatherData["main"]["temp"].ToString();

            // var temp = weatherData["main"]["temp"];
            // var feelsLike = weatherData["main"]["feels_like"];
            // var description = weatherData["weather"][0]["description"];
            // var humidity = weatherData["main"]["humidity"];
            // var windSpeed = weatherData["wind"]["speed"];
            //
            // return $"🌤️ Weather Report for {city}\n" +
            //        $"Temperature: {temp}°F\n" +
            //        $"Feels Like: {feelsLike}°F\n" +
            //        $"Condition: {description}\n" +
            //        $"Humidity: {humidity}%\n" +
            //        $"Wind Speed: {windSpeed} mph\n" +
            //        $"-----------------------------";
        }
    }
}