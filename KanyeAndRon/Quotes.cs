﻿
using System;
using Newtonsoft.Json.Linq;


namespace KanyeAndRon
{
	public class Quotes
	{
        public static void KanyeQuote()
        {

            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: \"{kanyeQuote}\"\n");
                      
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}\n");


        }

    } 
}

