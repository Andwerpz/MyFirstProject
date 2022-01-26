
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layouts.AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutView : ContentPage
    {
        public AbsoluteLayoutView()
        {
            InitializeComponent();
            BindingContext = new AbsoluteLayoutViewModel();
        }
    }
}