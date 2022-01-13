using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    public class PickerViewModel : BaseViewModel
    {
        public PickerViewModel()
        {
            Title = Titles.PickerTitle;
        }
    }
}
