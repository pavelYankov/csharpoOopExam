using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Classes
{
    class Boxer : Olympian, IBoxer
    {
        //fields
        private int wins;
        private int losses;

        //constructors
        public Boxer(string firstName,
            string lastName,
            string country,
            BoxingCategory category,
            int wins,
            int loses) : base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
        }

        //properies
        public BoxingCategory Category
        {
            get;
            private set;
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxNumber(value, 0, 100);
                this.wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxNumber(value, 0, 100);
                this.losses = value;
            }
        }

        //methods
        public override string GetObjectSpecifics()
        {
            return String.Format(@"Category: {0}
Wins: {1}
Losses: {2}",
            this.Category,
            this.Wins,
            this.Losses);
        }

        public override string GetObjectType()
        {
            return "BOXER";
        }
    }
}
