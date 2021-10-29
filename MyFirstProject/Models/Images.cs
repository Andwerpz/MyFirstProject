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
    }
}
