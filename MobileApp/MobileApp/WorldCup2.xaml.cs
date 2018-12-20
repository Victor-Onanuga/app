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
	public partial class WorldCup2 : ContentPage
	{
		public WorldCup2 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.qatar.png";
            qatarImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void homePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WorldCup());
        }
    }
}