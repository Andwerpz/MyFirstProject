
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Slider
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderView : ContentPage
    {
        public SliderView()
        {
            InitializeComponent();
            BindingContext = new SliderViewModel();
            this.SetPadding();
        }

        private void SetPadding()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = 20;
                    break;
                case Device.Android:
                    Padding = 10;
                    break;
            }
        }
    }
}