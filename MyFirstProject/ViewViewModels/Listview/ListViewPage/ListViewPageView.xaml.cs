using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageView : ContentPage
    {
        public ListViewPageView()
        {
            InitializeComponent();
            BindingContext = new ListViewPageViewModel();
        }
    }
}