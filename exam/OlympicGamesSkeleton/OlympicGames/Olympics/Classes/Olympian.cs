﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Classes
{
    public abstract class Olympian : IOlympian
    {
        //fields
        private string firstName;
        private string lastName;
        private string country;

        //constructors
        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }

        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, 2, 20,"First name must be between 2 and 20 characters long!");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, 2, 20, "Last name must be between 2 and 20 characters long!");
                this.lastName = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxLength(value, 3, 25, "Country must be between 3 and 25 characters long!");
                this.country = value;
            }
        }

        //methods
        //template methods :D ----
        public abstract string GetObjectSpecifics();
        
        public abstract string GetObjectType();
        //                    ----

        public override string ToString()
        {
            return String.Format(@"{0}: {1} {2} from {3}
{4}",
            this.GetObjectType(),
            this.FirstName,
            this.LastName,
            this.Country,
            this.GetObjectSpecifics());
        }
    }
}
