using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImageProject
{

    public partial class EmbeddedImageProjectView : ContentPage
    {
        public EmbeddedImageProjectView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImageProjectViewModel();
        }

    }
}