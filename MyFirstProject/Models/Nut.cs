using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Nut
    {
        public string Name { get; set; }

        public Nut()
        {
        }
        public Nut(string n)
        {
            Name = n;
        }

        public static List<Nut> GetNut()
        {
            return new List<Nut>
            {
                new Nut("Chris Pratt"),
                new Nut("Zoe Saldana"),
                new Nut("Vin Diesel"),
                new Nut("Bradely Cooper"),
                new Nut("Karen Gillan"),
                new Nut("Ophelia Lovibond"),
                new Nut("Laura Haddock")
            };
        }
    }
}
