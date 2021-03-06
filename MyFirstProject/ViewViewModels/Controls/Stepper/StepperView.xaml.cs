
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Stepper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperView : ContentPage
    {
        public StepperView()
        {
            InitializeComponent();
            BindingContext = new StepperViewModel();
        }

        public void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            if (value == 360)
                value = 0;
            else if (value == -360)
                value = 0;
            _stepper.Value = value;
            _displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}