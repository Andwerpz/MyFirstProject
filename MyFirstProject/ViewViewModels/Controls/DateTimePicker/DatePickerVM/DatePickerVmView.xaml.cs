using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker.DatePickerVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerVmView : ContentPage
    {
        public DatePickerVmView()
        {
            InitializeComponent();
            BindingContext = new DatePickerVmViewModel();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }

        private void DatePicker_DateSelected_1(object sender, DateChangedEventArgs e)
        {

        }
    }
}