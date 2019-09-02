using Pact2.View;
using Pact2.View.MasterDetail;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pact2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeTabbedPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
