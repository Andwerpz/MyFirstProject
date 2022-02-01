using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Picker.PickerVM;
using MyFirstProject.ViewViewModels.Controls.Picker.PickerXaml;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    public class PickerViewModel : BaseViewModel
    {
        public ICommand OnPickerXamlClicked { get; set; }
        public ICommand OnPickerVMCLicked { get; set; }
        public PickerViewModel()
        {
            Title = Titles.PickerTitle;

            OnPickerXamlClicked = new Command(OnPickerXamlClickedAsync);
            OnPickerVMCLicked = new Command(OnPickerVMClickedAsync);

        }

        private async void OnPickerVMClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVM.PickerResult());
        }

        private async void OnPickerXamlClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXamlView());
        }
    }
}
