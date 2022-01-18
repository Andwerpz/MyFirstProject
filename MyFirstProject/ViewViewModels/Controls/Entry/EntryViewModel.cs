

using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Entry.EntryPage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    public class EntryViewModel : BaseViewModel
    {
        public ICommand OnEntryPageClicked { get; set; }
        public EntryViewModel()
        {
            Title = Titles.EntryTitle;

            OnEntryPageClicked = new Command(OnEntryPageClickedAsync);
        }

        private async void OnEntryPageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryPageView());
        }
    }
}
