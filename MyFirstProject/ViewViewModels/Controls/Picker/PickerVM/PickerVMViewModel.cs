using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerVM
{
    public class PickerVMViewModel : BaseViewModel
    {
        public PickerVMViewModel()
        {
            Title = Titles.PickerVMTitle;
            setItemsSource();
        }

        public List<string> ItemsSource { get; set; }

        private void setItemsSource()
        {
            ItemsSource = new List<string> { "Nut", "Nut V2", "Nut V3", "Nut V4", "Nut V5" };
        }
    }
}
