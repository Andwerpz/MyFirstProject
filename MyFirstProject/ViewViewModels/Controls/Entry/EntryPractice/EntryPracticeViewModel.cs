using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice.EntryResult;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice
{
    public class EntryPracticeViewModel : BaseViewModel
    {
        public ICommand OnEntryPracticeClicked { get; }

        private string _entryText = string.Empty;
        public EntryPracticeViewModel()
        {
            Title = Titles.EntryPracticeTitle;
            OnEntryPracticeClicked = new Command(OnEntryPracticeClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }

            set
            {

                if (_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }

            }
        }

        private async void OnEntryPracticeClickedAsync(object obj)
        {
            Console.WriteLine("0");
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryPageTitle, "Entry Cannot Be Empty", "OK");
                return;
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EntryResultView(_entryText));
                return;
            }
        }
    }
}
