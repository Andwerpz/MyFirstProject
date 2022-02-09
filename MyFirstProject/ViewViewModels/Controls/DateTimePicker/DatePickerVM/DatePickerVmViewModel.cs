using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker.DatePickerVM
{
    public class DatePickerVmViewModel : BaseViewModel
    {
        private string msg;
        public ICommand OnSubmitClicked { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DatePickerVmViewModel()
        {
            Title = Titles.DatePickerVmTitle;
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVmTitle, msg, "OK");
        }
    }
}
