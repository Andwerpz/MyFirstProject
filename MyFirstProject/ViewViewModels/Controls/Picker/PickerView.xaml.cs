
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerView : ContentPage
    {
        public PickerView()
        {
            InitializeComponent();
            BindingContext = new PickerViewModel();
        }
    }
}