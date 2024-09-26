using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftEnums
{


    public class Person
    {
        //properties
        public string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0 || !string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("First name cannot be empty");
                }
            }
        }


        public string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 0 || !string.IsNullOrWhiteSpace(value))
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("Last name cannot be empty");
                }
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be less than 0");
                }
            }
        }


        //Constructor
        public Person(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        //Method that returns the persons full name
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
