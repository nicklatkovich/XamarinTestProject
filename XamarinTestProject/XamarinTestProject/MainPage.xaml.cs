﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestProject {
    public partial class MainPage : ContentPage {
        public MainPage( ) {
            InitializeComponent( );

            MusicIcon.Source = ImageSource.FromResource("XamarinTestProject.Images.musicIcon.png");
        }
    }
}
