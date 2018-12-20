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
	public partial class Stadiums2 : ContentPage
	{
		public Stadiums2 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.sdf.png";
            sdfImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void nextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stadiums3());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stadiums());
        }
    }
}