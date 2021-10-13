﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.ViewViewModels.Layouts.RelativeLayout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layouts.Relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutView : ContentPage
    {
        public RelativeLayoutView()
        {
            InitializeComponent();
            BindingContext = new RelativeLayoutViewModel();
        }
    }
}