using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Slider;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls
{
    public class ControlsMenuViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }
        public ControlsMenuViewModel()
        {
            Title = Titles.ControlsMenuTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);

        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }

    }
}
