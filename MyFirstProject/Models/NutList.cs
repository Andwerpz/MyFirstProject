using System.Collections.Generic;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class NutList
    {
        public ImageSource DeleteImageSrc { get; } = Images.DeleteImageSrc;

        public ImageSource UpdateImageSrc { get; } = Images.UpdateImageSrc;

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
                new NutList("nut nut"),
                new NutList("nut nut v2"),
                new NutList("nut nut v3"),
                new NutList("nut nut v6"),
                new NutList("nut nut v18"),
                new NutList("nut munt w1v23"),
                new NutList("nt wed vw nut nut nut v42"),
                new NutList("nut.")
            };
        }
    }
}
