using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Image.EmbeddedImage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image
{
    public class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnEmbeddedImageClicked { get; set; }
        public ImageMenuViewModel()
    {
            Title = Titles.ImageMenuTitle;
            OnEmbeddedImageClicked = new Command(OnEmbeddedImageClickedAsync);
    }

    private async void OnEmbeddedImageClickedAsync(object obj)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageView());
    }
}
}
