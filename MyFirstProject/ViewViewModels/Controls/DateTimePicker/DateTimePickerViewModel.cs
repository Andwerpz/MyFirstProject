using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.DateTimePicker.DatePickerVM;
using MyFirstProject.ViewViewModels.Controls.DateTimePicker.DatePickerXaml;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker
{
    public class DateTimePickerViewModel : BaseViewModel
    {
        public ICommand OnDatePickerXamlClicked { get; set; }
        public ICommand OnDatePickerVmClicked { get; set; }
        public DateTimePickerViewModel()
        {
            Title = Titles.DateTimePickerTitle;

            OnDatePickerXamlClicked = new Command(OnDatePickerXamlClickedAsync);
            OnDatePickerVmClicked = new Command(OnDatePickerVmClickedAsync);
        }

        private async void OnDatePickerXamlClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXamlView());
        }

        private async void OnDatePickerVmClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVmView());
        }
    }
}
