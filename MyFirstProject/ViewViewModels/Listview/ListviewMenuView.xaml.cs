
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewMenuView : ContentPage
    {
        public ListviewMenuView()
        {
            InitializeComponent();
            BindingContext = new ListviewMenuViewModel();
        }
    }
}