
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImageCache
{
    public partial class UriImageCacheView : ContentPage
    {
        public UriImageCacheView()
        {
            InitializeComponent();
            BindingContext = new UriImageCacheViewModel();
        }
    }
}