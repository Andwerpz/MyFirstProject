using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    internal class NutList
    {
        public string Nut { get; set; }

        public NutList()
        {
        }
        public NutList(string n)
        {
            Nut = n;
        }

        public static List<NutList> GetNutList()
        {
            return new List<NutList>
            {
                new NutList(""),
                new NutList(""),
                new NutList(""),
                new NutList(""),
                new NutList(""),
                new NutList(""),
                new NutList(""),
                new NutList("")
            };
        }
}
