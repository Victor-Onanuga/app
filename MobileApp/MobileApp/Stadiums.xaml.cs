using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stadiums : ContentPage
    {
        public Stadiums()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.campnou.png";
            campnouImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void nextPage(object sender, EventArgs e)//next page
        {
            Navigation.PushAsync(new Stadiums2());
        }

        private void Backbutton(object sender, EventArgs e)//back button
        {
            Navigation.PushAsync(new ChampionsLeague());
        }
    }
    }