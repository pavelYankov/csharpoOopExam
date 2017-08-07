using OlympicGames.Core;
using System;
using OlympicGames.Olympics.Classes;
using System.Collections.Generic;
using OlympicGames.Core.Factories;

namespace OlympicGames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Don not touch here (Magic Unicorns)
            Engine.Instance.Run();
            /*Boxer boxer = new Boxer("kinkdqw","wqfffq","fwqfqfqwf",Olympics.Enums.BoxingCategory.Heavyweight,10,20);
            Console.WriteLine(boxer);
            Dictionary<string, double> stats = new Dictionary<string, double>()
            {
                { "100m", 9.15 },
                { "200m", 10.2 }
            };
            Sprinter sprinter = new Sprinter("fwqfgqw", "rwqrqwr", "rwqrqrqwr", stats);
            Console.WriteLine(sprinter);*/
        }
    }
}
