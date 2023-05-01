using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace{ 
Console.WriteLine("Games and playtime");
var url = "https://steamcharts.com/";
var web = new HtmlWeb();
var dom = web.Load(url);
var cities = dom.DocumentNode.SelectNodes("//td");

for (int index = 0; index < cities.Count; index += 4)
{
    string temperature = cities[index + 3].InnerText;
    int posAmbersand = temperature.IndexOf('&');
    Console.WriteLine(cities[index].InnerText + "   " + cities[index + 3].InnerText.Remove(posAmbersand, 6));
}

