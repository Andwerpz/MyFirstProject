
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewImagesView : ContentPage
    {
        public ListViewImagesView()
        {
            InitializeComponent();
            BindingContext = new ListViewImagesViewModel();
        }
    }
}