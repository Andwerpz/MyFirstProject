﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsMenuView : ContentPage
    {
        public ControlsMenuView()
        {
            InitializeComponent();
            BindingContext = new ControlsMenuViewModel();

        }
    }
}