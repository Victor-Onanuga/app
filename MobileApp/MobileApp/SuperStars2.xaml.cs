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
	public partial class SuperStars2 : ContentPage
	{
		public SuperStars2 ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename = "MobileApp.Assets.messi.png";
            messiImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void homePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Backbutton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SuperStars());
        }
    }
}