using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPageView : ContentPage
    {
        public EntryPageView()
        {
            InitializeComponent();
            BindingContext = new EntryPageViewModel();
        }
    }
}