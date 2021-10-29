using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImageCache
{
    public class UriImageCacheViewModel : ImagesViewModel
    {
        public ImageSource UriImageSrc { get; set; }
        public UriImageCacheViewModel()
        {
            Title = Titles.UriImageCacheTitle;
        }
    }
}
