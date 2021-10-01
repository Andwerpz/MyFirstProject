using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls;
using MyFirstProject.ViewViewModels.Layouts;
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
        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;

            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsMenuView());
        }
    }
}
