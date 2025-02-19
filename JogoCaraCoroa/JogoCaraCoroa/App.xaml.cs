using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoCaraCoroa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Cria uma nova instância de uma página de navegação, onde a 'MainPage' é passada como a página inicial dessa navegação
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
