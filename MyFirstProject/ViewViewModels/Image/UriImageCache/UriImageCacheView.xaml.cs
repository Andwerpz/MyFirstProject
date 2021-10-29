using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.UriImageCache
{
    public partial class UriImageCacheView : ContentPage
    {
        public UriImageCacheView()
        {
            InitializeComponent();
            BindingContext = new UriImageCacheViewModel();
        }
    }
}