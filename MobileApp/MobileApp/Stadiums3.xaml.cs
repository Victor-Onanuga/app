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
	public partial class Stadiums3 : ContentPage
	{
		public Stadiums3 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.sansiro.png";
            sansiroImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void HomePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stadiums2());
        }
    }
}