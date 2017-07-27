using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Classes
{
    public class Sprinter : Olympian, ISprinter
    {
        //constructor
        public Sprinter(string firstName, string lastName, string country, IDictionary<string,double> personalRecorsd ) : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecorsd;
        }

        //properties
        public IDictionary<string, double> PersonalRecords
        {
            get;
            private set;
        }

        //methods
        public override string GetObjectSpecifics()
        {
            return String.Format(@"PERSONAL RECORDS:
100m: {0}s
200m: {1}s",
            this.PersonalRecords["100m"],
            this.PersonalRecords["200m"]);
        }

        public override string GetObjectType()
        {
            return "SPRINTER";
        }
    }
}
