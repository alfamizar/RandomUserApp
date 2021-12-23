﻿using RandomUserApp.Data.DataBases
;
using RandomUserApp.Presentation.UX.UI.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RandomUserApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
