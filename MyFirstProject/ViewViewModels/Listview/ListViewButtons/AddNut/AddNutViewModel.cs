using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons.AddNut
{
    public class AddNutViewModel : BaseViewModel
    {
        public ICommand btnAddClicked { get; set; }
        private string _nutText = string.Empty;

        public AddNutViewModel()
        {
            Title = Titles.AddTitle;
            btnAddClicked = new Command(PerformSave);
        }

        public string NutText
        {
            get { return _nutText; }
            set
            {
                if (_nutText != value)
                    SetProperty(ref _nutText, value);
            }
        }

        private void PerformSave()
        {
            if (String.IsNullOrEmpty(_nutText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddTitle, Titles.NotEmpty, "OK");
                return;
            }

            NutList nuts = new NutList(_nutText);

            MessagingCenter.Send<NutList>(nuts, "AddNutList");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
