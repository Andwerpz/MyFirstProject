using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModels.Listview.ListViewImages
{
    internal class ListViewImagesViewModel : BaseViewModel
    {
        public ObservableCollection<Nut> Nuts { get; }

        private List<Nut> _nut;
        public ListViewImagesViewModel()
        {
            Title = Titles.ListViewImagesTitle;
            Nuts = new ObservableCollection<Nut>();
            _nut = Nut.GetNut();
            this.LoadNuts();
        }

        private void LoadNuts()
        {
            try
            {
                Nuts.Clear();
                foreach (var n in _nut)
                {
                    Nuts.Add(n);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
