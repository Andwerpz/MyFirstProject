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
        List<Nut> NutCollection = Nut.GetNut();

        Nut selectedNut = new Nut();
        public PickerResultViewModel(string source, string name)
        {
            Title = name;
            SourcePage = source;
            GetNut(name);

            ImageSource = selectedNut.Image;
            Description = selectedNut.Description;

        }
        public string SourcePage { get; set; }
        public ImageSource ImageSource { get; set; }
        public string Description { get; set; }

        private void GetNut(string name)
        {
            foreach(Nut nut in NutCollection)
            {
                if (nut.Name == name)
                {
                    selectedNut = nut;
                    return;
                }
            }
            return;
        }

    }
}
