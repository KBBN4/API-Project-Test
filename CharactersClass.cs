using System;
using Newtonsoft.Json.Linq;
using System.Drawing;
namespace API_Project_Exercise
{
	public class CharactersClass
	{
        //public static void Name()
        //{
        //   var client = new HttpClient();


        //    var mickeyUrl = "http://api.disneyapi.dev/character?page=2&pageSize=50";

        //    var mickeyResponce = client.GetStringAsync(mickeyUrl).Result;

        //    var mickeyObject = JObject.Parse(mickeyResponce);

        //    Console.WriteLine(mickeyObject["data"][0]["name"]);


        //}


        public static void Name()
        {
            var client = new HttpClient();


            var mickeyUrl = "https://api.disneyapi.dev/character";

            var mickeyResponce = client.GetStringAsync(mickeyUrl).Result;

            var mickeyObject = JObject.Parse(mickeyResponce);

            // int index;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(mickeyObject["data"][i]["name"]);
            }

           
            //Console.WriteLine(mickeyObject["data"][1]["name"]);



        }







    }
}

