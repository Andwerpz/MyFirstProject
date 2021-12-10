using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Listview.ListViewButtons.EditNut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditNutView : ContentPage
    {
        public EditNutView(NutList nut)
        {
            InitializeComponent();
            BindingContext = new EditNutViewModel();
            Title.Text = nut.Nut;
        }
    }
}