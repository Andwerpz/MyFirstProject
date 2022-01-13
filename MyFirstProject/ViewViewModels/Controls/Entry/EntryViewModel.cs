

using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    public class EntryViewModel : BaseViewModel
    {
        public EntryViewModel()
        {
            Title = Titles.EntryTitle;
        }
    }
}
