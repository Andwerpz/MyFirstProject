
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutsMenuView : ContentPage
    {
        public LayoutsMenuView()
        {
            InitializeComponent();
            BindingContext = new LayoutsMenuViewModel();
        }
    }
}