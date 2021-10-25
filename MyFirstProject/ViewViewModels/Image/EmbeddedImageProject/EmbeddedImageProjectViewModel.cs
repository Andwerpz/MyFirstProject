﻿using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImageProject
{
    public class EmbeddedImageProjectViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }
        public EmbeddedImageProjectViewModel()
        {
            Title = Titles.EmbeddedImageProjectTitle;
            EmbeddedImageSrc = Images.EmbeddedImageProjectImageSrc;
        }
    }
}
