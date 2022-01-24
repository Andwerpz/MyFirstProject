﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPracticeView : ContentPage
    {
        public EntryPracticeView()
        {
            InitializeComponent();
            BindingContext = new EntryPracticeViewModel();
        }
    }
}