using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Image.ActivityIndicator;
using MyFirstProject.ViewViewModels.Image.EmbeddedImage;
using MyFirstProject.ViewViewModels.Image.EmbeddedImageProject;
using MyFirstProject.ViewViewModels.Image.UriImage;
using MyFirstProject.ViewViewModels.Image.UriImageCache;
using MyFirstProject.ViewViewModels.Image.UriImageProject;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image
{
    public class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnEmbeddedImageClicked { get; set; }
        public ICommand OnEmbeddedImageProjectClicked { get; set; }
        public ICommand OnUriImageClicked { get; set; }
        public ICommand OnUriImageProjectClicked { get; set; }
        public ICommand OnUriImageCacheClicked { get; set; }
        public ICommand OnActivityIndicatorClicked { get; set; }

        public ImageMenuViewModel()
        {
            Title = Titles.ImageMenuTitle;
            OnEmbeddedImageClicked = new Command(OnEmbeddedImageClickedAsync);
            OnEmbeddedImageProjectClicked = new Command(OnEmbeddedImageProjectClickedAsync);
            OnUriImageClicked = new Command(OnUriImageClickedAsync);
            OnUriImageProjectClicked = new Command(OnUriImageProjectClickedAsync);
            OnUriImageCacheClicked = new Command(OnUriImageCacheClickedAsync);
            OnActivityIndicatorClicked = new Command(OnActivityIndicatorAsync);
        }

        private async void OnActivityIndicatorAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
        }

        private async void OnUriImageCacheClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UriImageCacheView());
        }
        private async void OnUriImageProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UriImageProjectView());
        }
        private async void OnUriImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UriImageView());
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
