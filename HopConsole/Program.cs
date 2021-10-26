using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using HopClassLib;

namespace HopConsole
{
    class Program
    {
        static void Main(string[] args)
        { 
            
           List<Hop> DATA = new List<Hop>
            {
                new Hop {Id = 1, Name = "Amarillo", AlphaAcid = 7.5, HarvestYear = 2019, Price = 49},
                new Hop {Id = 2, Name = "Cascade US", AlphaAcid = 6.5, HarvestYear = 2020, Price = 69},
                new Hop {Id = 3, Name = "Chinook", AlphaAcid = 11.3, HarvestYear = 2020, Price = 65},
                new Hop {Id = 4, Name = "Mosaic, øko", AlphaAcid = 10.01, HarvestYear = 2020, Price = 85},
                new Hop {Id = 6, Name = "Saaz", AlphaAcid = 2.5, HarvestYear = 2020, Price = 45},
            };



            foreach (var x in DATA)
            {

                Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, AlphaAcid: {x.AlphaAcid}, HarvestYear: {x.HarvestYear}, Price: {x.Price}");

            }


        }
    }
}
