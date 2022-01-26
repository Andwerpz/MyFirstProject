
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview.ListViewIcons
{
    public partial class ListViewIconsView : ContentPage
    {
        public ListViewIconsView()
        {
            InitializeComponent();
            BindingContext = new ListViewIconsViewModel();
        }
    }
}