using APIsAndJSON;
using KanyeAndRon;

namespace APIsAndJSON
{
    public class Program
    {
         static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote(); 
            OpenWeatherMapAPI instanceWeather = new OpenWeatherMapAPI();
            Console.WriteLine(instanceWeather.Weather());

        }
    }
}
