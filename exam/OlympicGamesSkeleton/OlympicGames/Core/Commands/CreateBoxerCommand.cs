using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : CreateOlympianCommand
    {
        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override int AmountOfInfo()
        {
            return 6;
        }

        public override IOlympian Olimpian(string firstName, string lastName, string nationality)
        {
            string boxingCategory = this.CommandParameters[3];
            int wins = int.Parse(this.CommandParameters[4]);
            int losses = int.Parse(this.CommandParameters[5]);
            var boxer = this.Factory.CreateBoxer(firstName, lastName, nationality, boxingCategory, wins, losses);
            return boxer;
        }

        public override string OlympianType()
        {
            return "Boxer";
        }
    }
}
