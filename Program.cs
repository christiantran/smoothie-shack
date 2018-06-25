using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using smoothie_shack.Models;

namespace smoothie_shack
{
  public class Program
  {
    //BAD CODE, DONT DO THIS!!!
    public static List<Smoothie> Smoothies = new List<Smoothie>()
            {
                new Smoothie(4.99m, "Mango Madness", "Yo dawg we heard you like mangos",new List<string>(){
                    "Mangos",
                    "Madness"
                }),
                new Smoothie(4.99m, "Green Monster", "We put in all the veggies", new List<string>(){
                    "kale",
                    "spinach",
                    "healthy stuff"
                }),
                new Smoothie(5.99m, "Not So Healthy", "Basically a Milkshake", new List<string>(){
                    "ice cream",
                    "chocolate",
                    "peanut butter",
                    "eaters remorse"
                })
            };
    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
  }
}
