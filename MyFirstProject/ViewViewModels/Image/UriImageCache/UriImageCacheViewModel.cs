using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImageCache
{
    public class UriImageCacheViewModel : BaseViewModel
    {
        public ImageSource UriImageSrc { get; set; }
        public UriImageCacheViewModel()
        {
            Title = Titles.UriImageCacheTitle;
            UriImageSrc = SetImageSrc();
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
