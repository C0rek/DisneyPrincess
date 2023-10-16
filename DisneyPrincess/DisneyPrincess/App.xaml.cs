using DisneyPrincess.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisneyPrincess
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyListPage());
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
