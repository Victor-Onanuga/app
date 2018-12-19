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
	public partial class PremierLeague : ContentPage
	{
		public PremierLeague ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);



            string strFilename = "MobileApp.Assets.PremierLeague.png";
            PremierLeagueImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void TopScorer(object sender, EventArgs e)//TopScorer Back Button
        {

        }

        private void LeagueTable(object sender, EventArgs e)//League Table Button
        {

        }

        private void LeagueLegends(object sender, EventArgs e)//League Legends Button
        {

        }

        private void BackButton(object sender, EventArgs e)//Back Button
        {
            Navigation.PushAsync(new MainPage());
        }
 
    }
}