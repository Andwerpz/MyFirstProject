
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Switch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchView : ContentPage
    {
        public SwitchView()
        {
            InitializeComponent();
            BindingContext = new SwitchViewModel();
        }

        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
            {
                _testLabel.TextColor = Color.Red;
                _testLabel.Text = "Off";
                _testLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            }
            else
            {
                _testLabel.TextColor = Color.Blue;
                _testLabel.Text = "On";
                _testLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            }

        }
    }
}