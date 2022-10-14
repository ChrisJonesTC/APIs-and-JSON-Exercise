using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            RonVSKanyeAPI.KanyeQuote();
            Console.WriteLine();
            RonVSKanyeAPI.RonQuote();
            Console.WriteLine("---------------");
            RonVSKanyeAPI.KanyeQuote();
            Console.WriteLine();
            RonVSKanyeAPI.RonQuote();
            Console.WriteLine("---------------");
            RonVSKanyeAPI.KanyeQuote();
            Console.WriteLine();
            RonVSKanyeAPI.RonQuote();
            Console.WriteLine("---------------");
            RonVSKanyeAPI.KanyeQuote();
            Console.WriteLine();
            RonVSKanyeAPI.RonQuote();
            Console.WriteLine("---------------");
            RonVSKanyeAPI.KanyeQuote();
            Console.WriteLine();
            RonVSKanyeAPI.RonQuote();
            Console.WriteLine("---------------");
 

            OpenWeatherMapAPI.PhillyTemp();
        }
    }
}