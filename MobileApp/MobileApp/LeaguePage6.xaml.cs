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
	public partial class LeaguePage6 : ContentPage
	{
		public LeaguePage6 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.burnley.png";
            burnleyCrest.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void nextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeaguePage7());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeaguePage5());
        }
    }
}