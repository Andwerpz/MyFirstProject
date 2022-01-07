using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public static class Images
    {
        public static ImageSource EmbeddedImageProjectImageSrc { get; } = ImageSource.FromResource("MyFirstProject.Images.nut.jpg");

        public static ImageSource UriImageProjectImageSrc { get; } = ImageSource.FromUri(new Uri("https://placeimg.com/1000/1000/nature"));

        //Nut
        public static string HazelnutNutImageSrc { get; } = "https://static.toiimg.com/photo/msid-67255116/67255116.jpg?1395740";
        public static string PecanNutImageSrc { get; } = "https://iambaker.net/wp-content/uploads/2020/11/candied-pecans-3-1200x900.jpg";
        public static string AcornNutImageSrc { get; } = "https://i.guim.co.uk/img/media/10a07a65ef2505321698b57b1132d6a28d30def0/0_156_5000_2999/master/5000.jpg?width=1200&height=900&quality=85&auto=format&fit=crop&s=f8bd074ce88c2aaa9a54a7db95bed472";
        public static string WalnutNutImageSrc { get; } = "https://sodelicious.recipes/wp-content/uploads/2019/08/protective-walnut-power-e1565707989276-1200x900.jpg";
        public static string CashewNutImageSrc { get; } = "https://imgk.timesnownews.com/story/cashews.gif?tr=w-1200,h-900";
        public static string PeanutNutImageSrc { get; } = "https://gobadornot.com/wp-content/uploads/2020/11/Do-Peanuts-Go-Bad-1200x900.jpg";
        public static string AlmondNutImageSrc { get; } = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2020/04/28/21/almonds-1-sustainability-indyeats.jpg?width=1200&auto=webp&quality=75";

        //ListViewIcons
        public static ImageSource DeleteImageSrc { get; } = ImageSource.FromResource("MyFirstProject.Images.iconsdelete.png");
        public static ImageSource UpdateImageSrc { get; } = ImageSource.FromResource("MyFirstProject.Images.iconsedit.png");

    }
}
