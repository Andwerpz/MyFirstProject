using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using MyFirstProject.Models;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        ImageSource image = null;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        public ImageSource Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
