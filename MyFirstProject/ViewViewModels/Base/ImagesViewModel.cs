using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Base
{
    public class ImagesViewModel : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public ImagesViewModel()
        {
            Title = Titles.ImageTitle;
            ImageSrc = this.SetImageSrc();
        }

        private ImageSource SetImageSrc()
        {
            var imgsrc = new UriImageSource { Uri = new Uri("https://placeimg.com/1000/1000/nature") };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}
