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
        //fields

        //constructor
        public Sprinter(string firstName, string lastName, string country, IDictionary<string,double> personalRecorsd ) : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecorsd;
        }

        //properties
        public IDictionary<string, double> PersonalRecords
        {
            get;
            set;
        }

        //methods
        public override string GetObjectSpecifics()
        {
            if (this.PersonalRecords != null)
            {
                return String.Format(@"{0}
100m: {1}s
200m: {2}s",
                GlobalConstants.PersonalRecords,
                this.PersonalRecords["100m"],
                this.PersonalRecords["200m"]);
            }
            else
            {
                return GlobalConstants.NoPersonalRecordsSet;
            }
        }

        public override string GetObjectType()
        {
            return "SPRINTER";
        }
    }
}
