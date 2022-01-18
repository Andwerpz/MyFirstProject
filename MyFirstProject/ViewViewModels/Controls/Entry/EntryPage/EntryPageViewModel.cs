using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPage
{
    public class EntryPageViewModel : BaseViewModel
    {
        public ICommand OnEntryPageClicked { get; }
        private string _entryText = string.Empty; 
        public EntryPageViewModel()
        {
            Title = Titles.EntryPageTitle;
            OnEntryPageClicked = new Command(OnEntryPageClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }

            set 
            {
            
                if(_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }

            }
        }

        private async void OnEntryPageClickedAsync(object obj)
        {
            if(string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryPageTitle, "Entry Cannot Be Empty", "OK");
                return;
            }
        }
    }
}
