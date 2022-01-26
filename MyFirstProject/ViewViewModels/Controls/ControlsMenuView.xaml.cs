
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsMenuView : ContentPage
    {
        public ControlsMenuView()
        {
            InitializeComponent();
            BindingContext = new ControlsMenuViewModel();

        }
    }
}