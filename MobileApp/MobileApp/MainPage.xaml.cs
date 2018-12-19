using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);



            string strFilename = "MobileApp.Assets.football.png";
            football.Source = ImageSource.FromResource(strFilename, assembly);
        }


            private void PremierLeague_Clicked(object sender, EventArgs e)//Premier league button
        {
            Navigation.PushAsync(new PremierLeague());
        }

        private void ChampionsLeague(object sender, EventArgs e)//Champions League button
        {
            Navigation.PushAsync(new ChampionsLeague());
        }

        private void WorldCup(object sender, EventArgs e)//World Cup button
        {
            Navigation.PushAsync(new WorldCup());
        }

        private void AirtricityLeague(object sender, EventArgs e)//Airtricity Button
        {

        }

        /*nitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Tyr.png";
            imageTyr.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.TyrSymbol.png";
            imageTyrSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Tyr2.jpg";
            imageTyr2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Tyr3.jpg";
            imageTyr3.Source = ImageSource.FromResource(strFilename4, assembly);*/

    }
}
