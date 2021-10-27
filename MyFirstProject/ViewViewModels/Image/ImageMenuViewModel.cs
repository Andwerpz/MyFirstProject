using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Image.EmbeddedImage;
using MyFirstProject.ViewViewModels.Image.EmbeddedImageProject;
using MyFirstProject.ViewViewModels.Image.UrlImage;
using MyFirstProject.ViewViewModels.Image.UrlImageProject;
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
        public ICommand OnEmbeddedImageProjectClicked { get; set; }
        public ICommand OnUrlImageClicked { get; set; }
        public ICommand OnUrlImageProjectClicked { get; set; }

        public ImageMenuViewModel()
        {
            Title = Titles.ImageMenuTitle;
            OnEmbeddedImageClicked = new Command(OnEmbeddedImageClickedAsync);
            OnEmbeddedImageProjectClicked = new Command(OnEmbeddedImageProjectClickedAsync);
            OnUrlImageClicked = new Command(OnUrlImageClickedAsync);
            OnUrlImageProjectClicked = new Command(OnUrlImageProjectClickedAsync);
        }

        private void OnUrlImageProjectClickedAsync(object obj)
        {
            throw new NotImplementedException();
        }

        private async void OnUrlImageClickedAsync(object obj)
        {
        await Application.Current.MainPage.Navigation.PushAsync(new UrlImageView());
        }
        private async void OnEmbeddedImageClickedAsync(object obj)
        {
        await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageView());
        }
        private async void OnEmbeddedImageProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageProjectView());
        }
    }
}
