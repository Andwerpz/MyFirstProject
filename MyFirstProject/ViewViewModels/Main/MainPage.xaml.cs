using MyFirstProject.ViewViewModels.Main;
using Xamarin.Forms;

namespace MyFirstProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }


    }
}
