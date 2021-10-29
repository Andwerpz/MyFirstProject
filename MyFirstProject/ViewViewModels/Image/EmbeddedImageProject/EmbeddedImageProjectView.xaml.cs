using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImageProject
{

    public partial class EmbeddedImageProjectView : ContentPage
    {
        public EmbeddedImageProjectView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImageProjectViewModel();
        }

    }
}