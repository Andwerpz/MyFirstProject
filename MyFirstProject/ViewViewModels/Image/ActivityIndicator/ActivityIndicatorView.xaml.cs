using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.ActivityIndicator
{
    public partial class ActivityIndicatorView : ContentPage
    {
        public ActivityIndicatorView()
        {
            InitializeComponent();
            BindingContext = new ActivityIndicatorViewModel();
        }
    }
}