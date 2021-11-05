using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string n)
        {
            Name = n;
        }

        public static List<Person> GetPerson()
        {
            return new List<Person>
            {
                new Person("Chris Pratt"),
                new Person("Zoe Saldana"),
                new Person("Vin Diesel"),
                new Person("Bradely Cooper"),
                new Person("Karen Gillan"),
                new Person("Ophelia Lovibond"),
                new Person("Laura Haddock")
            };
        }
    }
}
