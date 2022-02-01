using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Picker.PickerResult
{
    public partial class PickerResultView : ContentPage
    {
        public PickerResultView(string source, string name)
        {
            InitializeComponent();
            BindingContext = new PickerResultViewModel(source, name);
        }
    }
}