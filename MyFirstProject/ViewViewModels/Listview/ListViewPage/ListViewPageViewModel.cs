using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModels.Listview.ListViewPage
{
    class ListViewPageViewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons {  get; }

        private List<Person> _person;
        public ListViewPageViewModel()
        {
            Title = Titles.ListViewPageTitle;
            Persons = new ObservableCollection<Person>();
            _person =Person.GetPerson();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                Persons.Clear();
                foreach (var p in _person)
                {
                    Persons.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        
    }
}

