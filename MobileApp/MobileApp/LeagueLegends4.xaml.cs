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
	public partial class LeagueLegends4 : ContentPage
	{
		public LeagueLegends4 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.cech.png";
            cechImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void HomePage(object sender, EventArgs e)//homepage button
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Backbutton(object sender, EventArgs e)//back button
        {
            Navigation.PushAsync(new LeagueLegends3());
        }
    }
}