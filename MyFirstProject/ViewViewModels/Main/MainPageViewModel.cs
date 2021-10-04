using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls;
using MyFirstProject.ViewViewModels.Image;
using MyFirstProject.ViewViewModels.Layouts;
using MyFirstProject.ViewViewModels.Listview;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand OnLayoutsMenuClicked { get; set; }
        public ICommand OnImageMenuClicked { get; set; }
        public ICommand OnListviewMenuClicked { get; set; }
        public ICommand OnControlsMenuClicked { get; set; }

        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;

            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
            OnImageMenuClicked = new Command(OnImageMenuClickedAsync);
            OnListviewMenuClicked = new Command(OnListviewMenuClickedAsync);
            OnControlsMenuClicked = new Command(OnControlsMenuClickedAsync);
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsMenuView());
        }
        private async void OnImageMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }
        private async void OnListviewMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListviewMenuView());
        }
        private async void OnControlsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }
    }
}
