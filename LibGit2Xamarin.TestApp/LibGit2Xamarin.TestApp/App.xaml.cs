using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LibGit2Xamarin.TestApp.Services;
using LibGit2Xamarin.TestApp.Views;

namespace LibGit2Xamarin.TestApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
