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
	public partial class LeagueLegends3 : ContentPage
	{
		public LeagueLegends3 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.giggs.png";
            giggsImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void nextPage(object sender, EventArgs e)//next button
        {
            Navigation.PushAsync(new LeagueLegends4());
        }

        private void Backbutton(object sender, EventArgs e)//back button
        {
            Navigation.PushAsync(new LeagueLegends2());
        }
    }
}