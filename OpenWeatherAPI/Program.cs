using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new HttpClient();
            var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json") // Path to your configuration file
    .Build();

            string apiKey = configuration.GetSection("ApiSettings")["ApiKey"];
            Console.WriteLine("Please enter your zip:");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units=imperial";

            Console.WriteLine();

           var results = client.GetStringAsync(apiCall).Result;
           var finalAnswer = JObject.Parse(results);
            Console.WriteLine($"The current temp is: {finalAnswer["main"]["temp"]}. The high for today is: " +
                $" {finalAnswer["main"]["temp_max"]}. The low for today is: {finalAnswer["main"]["temp_min"]} " +
                $"The humidity today is: {finalAnswer["main"]["humidity"]}");


        }
    }
}