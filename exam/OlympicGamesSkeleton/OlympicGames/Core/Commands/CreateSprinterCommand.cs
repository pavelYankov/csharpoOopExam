using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : CreateOlympianCommand
    {
        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override int AmountOfInfo()
        {
            return 3;
        }

        public override IOlympian Olimpian(string firstName, string lastName, string nationality)
        {
            Dictionary<string, double> stats;
            if (CommandParameters.Count > 3)
            {
                string[] oneHundredMeters = this.CommandParameters[3].Split('/');
                string[] twoHundredMeters = this.CommandParameters[4].Split('/');
                stats = new Dictionary<string, double>()
            {
                { oneHundredMeters[0] +"m", double.Parse(oneHundredMeters[1]) },
                { twoHundredMeters[0] +"m", double.Parse(twoHundredMeters[1]) }
            };
            }
            else
            {
                stats = null;
            }
            var sprinter = this.Factory.CreateSprinter(firstName, lastName, nationality, stats);
            return sprinter;
        }

        public override string OlympianType()
        {
            return "Sprinter";
        }
    }
}
