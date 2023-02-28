using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

do
{


    HttpClient client = new HttpClient();

    var apiKey = "69c3ef29cb535b9f6ae3a96c94ccf87f";

    Console.WriteLine("Enter in a city name:     ");
    var cityName = Console.ReadLine();

    var URL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
 

    var response = client.GetStringAsync(URL).Result;

    var formattedResponse = JObject.Parse(response);

    Console.WriteLine($"The current temperature in {cityName} is {formattedResponse["main"]["temp"]} Fahrenheight");
    Console.WriteLine();

    Console.WriteLine("Do you want to enter another city?");
    var answer = Console.ReadLine();
    

    if (answer == "yes")
    {
        continue;
    }
    else
    {
        break;
    }
    

} while (true);


















//switch(answer)
//{
//    case "yes":
//    Console.WriteLine("Enter in a city name:     ");
//    var cityName1 = Console.ReadLine();

//    var URL1 = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

//    var response1 = client.GetStringAsync(URL).Result;

//    var formattedResponse1 = JObject.Parse(response1);

//    Console.WriteLine($"The current temperature in {cityName1} is {formattedResponse1["main"]["temp"]} Fahrenheight");
//        break;
//    case "no":
//    Console.WriteLine("Thanks for using my program :)");
//        break;
//        foreach (var item in answer)
//        {
//            Console.WriteLine(item);
//            answer++;
//        }
//}


