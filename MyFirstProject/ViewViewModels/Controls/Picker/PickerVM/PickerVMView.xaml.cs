using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerVM
{
    public partial class PickerResult : ContentPage
    {
        public PickerResult()
        {
            InitializeComponent();
            BindingContext = new PickerVMViewModel();
        }
    }
}