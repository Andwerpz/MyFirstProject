using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Listview.ListViewButtons.AddNut;
using MyFirstProject.ViewViewModels.Listview.ListViewButtons.EditNut;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            get
            {
                return new Command<NutList>((NutList nut) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new EditNutView(nut));

                    MessagingCenter.Subscribe<NutList>(this, "UpdateNutList", async (data) =>
                    {
                        var index = NutsList.IndexOf(nut);

                        NutsList.RemoveAt(index);

                        NutsList.Insert(index, data);

                        MessagingCenter.Unsubscribe<NutList>(this, "UpdateNutList");
                    });
                });
            }
        }

        public Command<NutList> AddCommand
        {
            get
            {
                return new Command<NutList>((NutList nut) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new AddNutView());

                    MessagingCenter.Subscribe<NutList>(this, "AddNutList", async (data) =>
                    {
                        NutsList.Add(data);

                        MessagingCenter.Unsubscribe<NutList>(this, "AddNutList");
                    });
                });
            }
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
