//using Newtonsoft.Json.Linq;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace APIsAndJSON
//{
//    public class QuoteGenerator
//    {
//        public static void KanyeQuote()
//        {
//            var client = new HttpClient();

//            var kanyeURL = "https://api.kanye.rest/";

//            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

//            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

//            Console.WriteLine($"-------------------");
//            Console.WriteLine($" Kanye:'{kanyeQuote}'");
//            Console.WriteLine($"-------------------");

//        }

//        public static void RonQuote()
//        {
//            var client = new HttpClient();

//            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

//            var ronResponse = client.GetStringAsync(ronURL).Result;

//            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            

//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("------------------------");
//                Console.WriteLine($"Kanye: {KanyeQuote}");

//                Console.WriteLine($"Ron Swanson: {ronQuote}");
//            }
//        }
//    }
//}
