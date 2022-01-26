using MyFirstProject.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons.EditNut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditNutView : ContentPage
    {
        public EditNutView(NutList nut)
        {
            InitializeComponent();
            BindingContext = new EditNutViewModel();
            Title.Text = nut.Nut;
        }
    }
}