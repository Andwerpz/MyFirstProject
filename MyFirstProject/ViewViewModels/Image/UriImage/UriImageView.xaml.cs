
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImage
{
    public partial class UriImageView : ContentPage
    {
        public UriImageView()
        {
            InitializeComponent();
            BindingContext = new UriImageViewModel();
        }
    }
}