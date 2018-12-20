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
	public partial class TopScorer3 : ContentPage
	{
		public TopScorer3 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.sterling.png";
            sterlingImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void Homepage(object sender, EventArgs e)//homepage button
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Backbutton(object sender, EventArgs e)//back button
        {
            Navigation.PushAsync(new TopScorer2());
        }
    }
}