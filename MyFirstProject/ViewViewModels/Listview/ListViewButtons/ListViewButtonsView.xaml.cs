
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons
{
    public partial class ListViewButtonsView : ContentPage
    {
        public ListViewButtonsView()
        {
            InitializeComponent();
            BindingContext = new ListViewButtonsViewModel();
        }
    }
}