using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview.ListViewIcons.EditNut
{
    public class EditNutViewModel : BaseViewModel
    {
        public ICommand btnUpdateClicked { get; set; }
        private string _nutText = string.Empty;

        public EditNutViewModel()
        {
            Title = Titles.EditTitle;
            btnUpdateClicked = new Command(PerformSave);
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

            MessagingCenter.Send<NutList>(nuts, "UpdateNutList");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
