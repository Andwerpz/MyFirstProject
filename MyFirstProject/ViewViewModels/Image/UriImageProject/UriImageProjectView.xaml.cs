using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.UriImageProject
{
    public partial class UriImageProjectView : ContentPage
    {
        public UriImageProjectView()
        {
            InitializeComponent();
            BindingContext = new UriImageProjectViewModel();
        }
    }
}