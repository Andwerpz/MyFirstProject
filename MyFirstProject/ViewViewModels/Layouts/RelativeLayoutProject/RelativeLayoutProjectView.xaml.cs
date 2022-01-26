
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layouts.RelativeLayoutProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutProjectView : ContentPage
    {
        public RelativeLayoutProjectView()
        {
            InitializeComponent();
            BindingContext = new RelativeLayoutProjectViewModel();
        }
    }
}