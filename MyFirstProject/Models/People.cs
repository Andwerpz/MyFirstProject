using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class People
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource Image { get; set; }

        public People()
        {
        }
        public People(string n, string d, ImageSource i)
        {
            Name = n;
            Description = d;
            Image = i;
        }

        public static List<People> GetList()
        {
            return new List<People>
            {
                new People("Yellow", "pretty yellow tbh", Images.Yellow),
                new People("Blue", "pretty blue tbh", Images.Blue),
                new People("Yellow 2", "more yellow this time", Images.Yellow2),
                new People("Orange", "pretty orange if you ask me", Images.Orange),
                new People("White", "uhhhhhhh...", Images.White),
            };
        }
    }
}
