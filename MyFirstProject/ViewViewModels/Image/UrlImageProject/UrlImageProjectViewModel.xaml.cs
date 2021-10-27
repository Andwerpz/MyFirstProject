using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.UrlImageProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrlImageProjectViewModel : ContentPage
    {
        public UrlImageProjectViewModel()
        {
            InitializeComponent();
            BindingContext = new UrlImageProjectViewModel();
        }
    }
}