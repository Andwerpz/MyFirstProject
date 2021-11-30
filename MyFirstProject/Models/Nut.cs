using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MyFirstProject.Models;

namespace MyFirstProject.Models
{
    public class Nut
    {
        public string Name { get; set; }
        public ImageSource Image { get; set; }

        public Nut()
        {
        }
        public Nut(string n, string i)
        {
            Name = n;
            Image = ImageSource.FromUri(new Uri(i));
        }

        public static List<Nut> GetNut()
        {
            return new List<Nut>
            {
                new Nut("Peanut Nut", Images.PeanutNutImageSrc),
                new Nut("Almond Nut", Images.AlmondNutImageSrc),
                new Nut("Acorn Nut", Images.AcornNutImageSrc),
                new Nut("Cashew Nut", Images.CashewNutImageSrc),
                new Nut("Walnut Nut", Images.WalnutNutImageSrc),
                new Nut("Hazelnut Nut", Images.HazelnutNutImageSrc),
                new Nut("Nutty Pecan Nut", Images.PecanNutImageSrc)
            };
        }

    }
}
