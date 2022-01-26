
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons.AddNut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNutView : ContentPage
    {
        public AddNutView()
        {
            InitializeComponent();
            BindingContext = new AddNutViewModel();
        }
    }
}