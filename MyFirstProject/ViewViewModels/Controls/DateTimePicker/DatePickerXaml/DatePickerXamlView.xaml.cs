using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker.DatePickerXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerXamlView : ContentPage
    {
        private DateTime _startDateSelected = new DateTime( 01 / 01 / 2021);
        private DateTime _oldStartDateSelected;
        private DateTime _endDateSelected = new DateTime(01 / 01 / 2021);
        private DateTime _oldEndDateSelected;

        public DatePickerXamlView()
        {
            InitializeComponent();
            BindingContext = new DatePickerXamlViewModel();
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _startDateSelected = e.NewDate;
            _oldStartDateSelected = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _endDateSelected = e.NewDate;
            _oldEndDateSelected = e.OldDate;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string msg = "Start Date: " + _startDateSelected.ToShortDateString() + ",\n End Date:" + _endDateSelected.ToShortDateString();

            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerXamlTitle, msg, "OK");

        }
    }
}