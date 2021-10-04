using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image
{
    public class ImageMenuViewModel : BaseViewModel
    {
        public ImageMenuViewModel()
        {
            Title = Titles.ImageMenuTitle;
        }
    }
}
