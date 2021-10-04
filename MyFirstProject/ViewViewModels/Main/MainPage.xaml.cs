﻿using MyFirstProject.ViewViewModels.Controls;
using MyFirstProject.ViewViewModels.Image;
using MyFirstProject.ViewViewModels.Layouts;
using MyFirstProject.ViewViewModels.Listview;
using MyFirstProject.ViewViewModels.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        
    }
}