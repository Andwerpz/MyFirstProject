
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.ActivityIndicator
{
    public partial class ActivityIndicatorView : ContentPage
    {
        public ActivityIndicatorView()
        {
            InitializeComponent();
            BindingContext = new ActivityIndicatorViewModel();
        }
    }
}