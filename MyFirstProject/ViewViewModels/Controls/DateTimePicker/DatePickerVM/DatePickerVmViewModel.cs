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
        public DatePickerVmViewModel()
        {
            Title = Titles.DatePickerVmTitle;
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public DateTime StartDate { get; set; } = Dates.CurrentDate;
        public DateTime EndDate { get; set; } = Dates.CurrentDate;

        public DateTime MinDate
        {
            get
            {
                return Dates.MinDate;
            }
        }

        public DateTime MaxDate
        {
            get
            {
                return Dates.MaxDate;
            }
        }
        public Boolean SwitchToggled { get; set; }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (StartDate > EndDate)
                await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVmTitle, "Start date cannot be after the end date", "OK");
            //if the date is valid, display message with a modification if switch is toggled, or just plain if switch is not toggled
            else
            {
                msg = "Start Date: " + StartDate.ToShortDateString() + ",\n End Date: " + EndDate.ToShortDateString();

                if (SwitchToggled)
                    msg += "\n Difference: " + EndDate.Subtract(StartDate).Days + " Days";

                await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVmTitle, msg, "OK");
            }
                
        }
    }
}
