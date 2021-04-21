using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3TagliacozzoNR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habiltar la navegacion
            MainPage =  new NavigationPage (new MainPage());
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
