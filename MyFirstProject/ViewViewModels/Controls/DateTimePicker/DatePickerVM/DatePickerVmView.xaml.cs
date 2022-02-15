using MyFirstProject.Models;
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
        DatePickerVmViewModel vm = new DatePickerVmViewModel();
        public DatePickerVmView()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            vm.StartDate = e.NewDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            vm.EndDate = e.NewDate;            
        }
    }
}