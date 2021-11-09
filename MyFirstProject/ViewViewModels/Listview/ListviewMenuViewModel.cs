using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MyFirstProject.ViewViewModels.Listview.ListViewPage;

namespace MyFirstProject.ViewViewModels.Listview
{
    class ListviewMenuViewModel : BaseViewModel
    {
        public ICommand OnListViewPageClicked { get; set; }
        public ListviewMenuViewModel()
        {
            Title = Titles.ListviewMenuTitle;
            OnListViewPageClicked = new Command(OnListViewPageClickedAsync);
        }

        private async void OnListViewPageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewPageView());
        }
    }
}
