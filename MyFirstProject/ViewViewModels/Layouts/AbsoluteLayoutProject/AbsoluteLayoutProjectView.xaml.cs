
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layouts.AbsoluteLayoutProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutProjectView : ContentPage
    {
        public AbsoluteLayoutProjectView()
        {
            InitializeComponent();
            BindingContext = new AbsoluteLayoutProjectViewModel();
        }
    }
}