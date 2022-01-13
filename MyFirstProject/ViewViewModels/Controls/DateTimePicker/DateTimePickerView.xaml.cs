using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DateTimePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateTimePickerView : ContentPage
    {
        public DateTimePickerView()
        {
            InitializeComponent();
            BindingContext = new DateTimePickerViewModel();
        }
    }
}