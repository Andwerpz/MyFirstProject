using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons
{
    public class ListViewButtonsViewModel : BaseViewModel
    {

        private List<NutList> _nutList;
        private ObservableCollection<NutList> _nutLists;
        public ListViewButtonsViewModel()
        {
            Title = Titles.ListViewButtonsTitle;
            NutsList = new ObservableCollection<NutList>();
            _nutList = NutList.GetNutList();
            this.LoadNutsList();
        }

        public ObservableCollection<NutList> NutsList
        {
            get
            {
                return _nutLists;
            }
            set
            {
                _nutLists = value;
                OnPropertyChanged();
            }
        }

        public Command<NutList> DeleteCommand
        {
            get
            {
                return new Command<NutList>((NutList nut) => 
                { 
                    NutsList.Remove(nut); 
                });
            }
        }

        public Command<NutList> UpdateCommand
        {

        }

        private void LoadNutsList()
        {
            try
            {
                NutsList.Clear();
                foreach (var n in _nutList)
                {
                    NutsList.Add(n);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
