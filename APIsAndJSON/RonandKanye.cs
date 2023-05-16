using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonandKanye
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();


            for (int i = 1; i <= 5; i++)
            {
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();



            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {kanyeQuote}");
               Console.WriteLine();
                Console.WriteLine($"Ron Swanson: {ronQuote}");
            }


        }
    }
}
