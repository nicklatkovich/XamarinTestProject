using System;
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
            PhoneIcon.Source = ImageSource.FromResource("XamarinTestProject.Images.phoneIcon.png");
            CameraIcon.Source = ImageSource.FromResource("XamarinTestProject.Images.cameraIcon.png");
            ExplorerIcon.Source = ImageSource.FromResource("XamarinTestProject.Images.explorerIcon.png");
            Header.Source = ImageSource.FromResource("XamarinTestProject.Images.mainHeaderLogo.png");
        }
    }
}
