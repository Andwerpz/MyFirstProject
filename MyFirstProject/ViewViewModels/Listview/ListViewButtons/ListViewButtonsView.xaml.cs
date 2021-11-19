using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons
{
    public partial class ListViewButtonsView : ContentPage
    {
        public ListViewButtonsView()
        {
            InitializeComponent();
            BindingContext = new ListViewButtonsViewModel();
        }
    }
}