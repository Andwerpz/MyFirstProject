using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Picker.PickerResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerXaml
{
    public class PickerXamlViewModel : BaseViewModel
    {
        public ICommand OnSubmitClicked { get; set; }
        private string _name = string.Empty;
        public PickerXamlViewModel()
        {
            Title = Titles.PickerXamlTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedItem
        {
            get { return _name; }

            set
            {

                if (_name != value)
                {
                    SetProperty(ref _name, value);
                }

            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_name.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerVMTitle, "Select an Option First", "OK");
                return;
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PickerResultView("Picker XAML", _name));
            }
        }
    }
}
