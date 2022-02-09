using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerResult
{
    public class PickerResultViewModel : BaseViewModel
    {
        public PickerResultViewModel(string name, ImageSource image, string description, string source)
        {
            Title = name;
            SourcePage = source;

            ImageSource = image;
            Description = description;

        }
        public string SourcePage { get; set; }
        public ImageSource ImageSource { get; set; }
        public string Description { get; set; }

        

    }
}
