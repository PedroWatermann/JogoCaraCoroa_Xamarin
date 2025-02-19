using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JogoCaraCoroa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnJogar_Clicked(object sender, EventArgs e)
        {
            // Chama a página 'PgeJogo'
            await Navigation.PushAsync(new PgeJogo(), true); // 'true' habilita animação na transição das páginas
        }
    }
}
