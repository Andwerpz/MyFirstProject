using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Picker.PickerResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerVM
{
    public class PickerVMViewModel : BaseViewModel
    {
        List<Nut> nut = Nut.GetNut();

        private string _name = string.Empty;

        public List<string> ItemsSource { get; set; }

        public ICommand OnSubmitClicked { get; set; }
        public PickerVMViewModel()
        {
            Title = Titles.PickerVMTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);

            ItemsSource = (from n in nut select n.Name).ToList();
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

            var result = nut.FirstOrDefault(x => x.Name.Equals(SelectedItem));

            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultView(result.Name, result.Image, result.Description, "Picker VM"));
        }

    }
}
