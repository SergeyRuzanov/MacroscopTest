using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MacroscopTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MacroscopTest.Views.CamerasListPage();
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
