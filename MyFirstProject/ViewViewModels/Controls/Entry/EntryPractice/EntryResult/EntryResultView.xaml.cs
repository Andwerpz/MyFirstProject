using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice.EntryResult
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryResultView : ContentPage
    {
        public EntryResultView(String _entryText)
        {
            InitializeComponent();
            BindingContext = new EntryResultViewModel(_entryText);
        }
    }
}