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
	public partial class ChampionsLeague : ContentPage
	{
		public ChampionsLeague ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);



            string strFilename = "MobileApp.Assets.ChampionsLeague.png";
            ChampionsLeagueImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void AboutTheCl(object sender, EventArgs e)//About Champions League
        {
            Navigation.PushAsync(new AboutTheCl());
        }

        private void Stadiums(object sender, EventArgs e)//Stadiums and fans
        {
            Navigation.PushAsync(new Stadiums());
        }

        private void SuperStars(object sender, EventArgs e)//Super stars
        {
            Navigation.PushAsync(new SuperStars());
        }

        private void BackButton(object sender, EventArgs e)//Back Button
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}