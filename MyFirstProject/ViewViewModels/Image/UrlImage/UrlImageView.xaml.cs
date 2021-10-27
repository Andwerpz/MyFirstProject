using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.UrlImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrlImageView : ContentPage
    {
        public UrlImageView()
        {
            InitializeComponent();
            BindingContext = new UrlImageViewModel();
        }
    }
}