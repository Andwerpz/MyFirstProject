using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice.EntryResult
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryResultView : ContentPage
    {
        public EntryResultView(String text)
        {
            InitializeComponent();
            BindingContext = new EntryResultViewModel();
            Result.Text = text;
        }
    }
}