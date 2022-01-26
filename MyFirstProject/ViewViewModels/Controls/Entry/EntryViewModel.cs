

using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Controls.Entry.EntryPage;
using MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    public class EntryViewModel : BaseViewModel
    {
        public ICommand OnEntryPageClicked { get; set; }
        public ICommand OnEntryPracticeClicked { get; set; }
        public EntryViewModel()
        {
            Title = Titles.EntryTitle;

            OnEntryPageClicked = new Command(OnEntryPageClickedAsync);
            OnEntryPracticeClicked = new Command(OnEntryPracticeClickedAsync);
        }

        private async void OnEntryPageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryPageView());
        }
        private async void OnEntryPracticeClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryPracticeView());
        }
    }
}
