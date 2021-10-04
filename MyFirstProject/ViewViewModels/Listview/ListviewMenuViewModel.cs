using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Listview
{
    class ListviewMenuViewModel : BaseViewModel
    {
        public ListviewMenuViewModel()
        {
            Title = Titles.ListviewMenuTitle;
        }
    }
}
