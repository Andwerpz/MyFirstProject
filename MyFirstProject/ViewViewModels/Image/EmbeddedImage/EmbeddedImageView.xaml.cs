
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImageView : ContentPage
    {
        public EmbeddedImageView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImageViewModel();
        }
    }
}