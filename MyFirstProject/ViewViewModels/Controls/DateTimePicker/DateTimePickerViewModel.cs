using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker
{
    public class DateTimePickerViewModel : BaseViewModel
    {
        public DateTimePickerViewModel()
        {
            Title = Titles.DateTimePickerTitle;
        }
    }
}
