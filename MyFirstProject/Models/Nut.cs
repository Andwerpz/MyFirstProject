using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class Nut
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource Image { get; set; }

        public Nut()
        {
        }
        public Nut(string n, string d, string i)
        {
            Name = n;
            Description = d;
            Image = ImageSource.FromUri(new Uri(i));
        }

        public static List<Nut> GetNut()
        {
            return new List<Nut>
            {
                new Nut("Peanut Nut", "Goog nut", Images.PeanutNutImageSrc),
                new Nut("Almond Nut", "No goog nut", Images.AlmondNutImageSrc),
                new Nut("Acorn Nut", "No goog nut", Images.AcornNutImageSrc),
                new Nut("Cashew Nut", "No goog nut", Images.CashewNutImageSrc),
                new Nut("Walnut Nut", "Goog nut", Images.WalnutNutImageSrc),
                new Nut("Hazelnut Nut", "Goog nut", Images.HazelnutNutImageSrc),
                new Nut("Nutty Pecan Nut", "Goog nut", Images.PecanNutImageSrc)
            };
        }

    }
}
