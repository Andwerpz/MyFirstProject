using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImageProject
{
    public class UriImageProjectViewModel : BaseViewModel
    {
        public ImageSource UriImageSrc { get; set; }
        public UriImageProjectViewModel()
        {
            Title = Titles.UriImageProjectTitle;
            UriImageSrc = Images.UriImageProjectImageSrc;
        }
    }
}
