using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImage
{
    public class EmbeddedImageViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }
        public EmbeddedImageViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
            this.GetEmbeddedImageSrc();
        }

        private void GetEmbeddedImageSrc()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.nut.jpg");
        }
    }
}
