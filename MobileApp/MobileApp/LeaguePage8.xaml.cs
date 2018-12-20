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
	public partial class LeaguePage8 : ContentPage
	{
		public LeaguePage8 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.fulham.png";
            fulhamCrest.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeaguePage7());
        }

        private void HomePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}