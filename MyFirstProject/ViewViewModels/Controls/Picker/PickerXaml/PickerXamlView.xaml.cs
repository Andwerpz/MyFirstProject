using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerXaml
{
    public partial class PickerXamlView : ContentPage
    {
        public PickerXamlView()
        {
            InitializeComponent();
            BindingContext = new PickerXamlViewModel();
        }
    }
}