using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image
{
    public partial class ImageMenuView : ContentPage
    {
        public ImageMenuView()
        {
            InitializeComponent();
            BindingContext = new ImageMenuViewModel();
        }
    }
}