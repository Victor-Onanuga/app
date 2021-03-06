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
	public partial class LeagueTable : ContentPage
	{
		public LeagueTable ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.liverpool.png";
            liverpoolCrest.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void nextPage(object sender, EventArgs e)//next page button
        {
            Navigation.PushAsync(new LeaguePage2());
        }

        private void Backbutton(object sender, EventArgs e)//back button
        {
            Navigation.PushAsync(new PremierLeague());
        }
    }
}