using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using MyFirstProject.ViewViewModels.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModels.Layouts.AbsoluteLayoutProject;
using MyFirstProject.ViewViewModels.Layouts.Relative;
using MyFirstProject.ViewViewModels.Layouts.RelativeLayoutProject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layouts
{
    public class LayoutsMenuViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public ICommand OnAbsoluteLayoutProjectClicked { get; set; }
        public ICommand OnRelativeLayoutClicked { get; set; }
        public ICommand OnRelativeLayoutProjectClicked { get; set; }
        public LayoutsMenuViewModel()
        {
            Title = Titles.LayoutsMenuTitle;

            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);
            OnAbsoluteLayoutProjectClicked = new Command(OnAbsoluteLayoutProjectClickedAsync);
            OnRelativeLayoutClicked = new Command(OnRelativeLayoutClickedAsync);
            OnRelativeLayoutProjectClicked = new Command(OnRelativeLayoutProjectClickedAsync);
        }

        private async void OnAbsoluteLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutProjectView());
        }

        private async void OnRelativeLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }
        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
        private async void OnRelativeLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutProjectView());
        }
    }
}
