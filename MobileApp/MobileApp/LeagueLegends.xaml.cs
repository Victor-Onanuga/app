﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LeagueLegends : ContentPage
	{
		public LeagueLegends ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.shearer.png";
            shearerImage.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void nextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeagueLegends2());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PremierLeague());
        }
    }
}