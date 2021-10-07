using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Layouts.AbsoluteLayout;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layouts
{
    public class LayoutsMenuViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public LayoutsMenuViewModel()
        {
            Title = Titles.LayoutsMenuTitle;

            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);
        }

        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
    }
}
