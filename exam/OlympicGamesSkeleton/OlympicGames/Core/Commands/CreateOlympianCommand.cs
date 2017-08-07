using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Utils;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Commands
{
    public abstract class CreateOlympianCommand : Command
    {
        public CreateOlympianCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override string Execute()
        {
            if (CommandParameters.Count < this.AmountOfInfo()) 
            {
                throw new Exception(GlobalConstants.ParametersCountInvalid);
            }
            string firstName = this.CommandParameters[0];
            string lastName = this.CommandParameters[1];
            string nationality = this.CommandParameters[2];

            IOlympian olympian = this.Olimpian(firstName,lastName,nationality);
            string returnOlympian = String.Format(@"Created {0}
{1}",
this.OlympianType(),
olympian.ToString()
);
            this.Committee.Olympians.Add(olympian);
            return returnOlympian;
        }

        public abstract int AmountOfInfo();
        public abstract IOlympian Olimpian(string firstName, string lastName, string nationality);
        public abstract string OlympianType();
    }
}
