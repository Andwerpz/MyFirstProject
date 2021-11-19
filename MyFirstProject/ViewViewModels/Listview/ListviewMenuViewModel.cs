using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModels.Listview.ListViewPage;
using MyFirstProject.ViewViewModels.Listview.ListViewImages;
using MyFirstProject.ViewViewModels.Listview.ListViewButtons;
using MyFirstProject.ViewViewModels.Listview.ListViewIcons;

namespace MyFirstProject.ViewViewModels.Listview
{
    class ListviewMenuViewModel : BaseViewModel
    {
        public ICommand OnListViewPageClicked { get; set; }
        public ICommand OnListViewImagesClicked { get; set; }
        public ICommand OnListViewButtonsClicked { get; set; }
        public ICommand OnListViewIconsClicked { get; set; }

        public ListviewMenuViewModel()
        {
            Title = Titles.ListviewMenuTitle;
            OnListViewPageClicked = new Command(OnListViewPageClickedAsync);
            OnListViewImagesClicked = new Command(OnListViewImagesClickedAsync);
            OnListViewButtonsClicked = new Command(OnListViewButtonsClickedAsync);
            OnListViewIconsClicked = new Command(OnListViewIconsClickedAsync);
        }

        private async void OnListViewPageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewPageView());
        }

        private async void OnListViewImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewImagesView());
        }

        private async void OnListViewButtonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewButtonsView());
        }

        private async void OnListViewIconsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewIconsView());
        }
    }
}
