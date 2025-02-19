using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoCaraCoroa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgeJogo : ContentPage
    {
        public PgeJogo()
        {
            InitializeComponent();

            Random r = new Random();
            int n = r.Next(1, 3); // Sorteia um número de 1 a 3
            if (n == 1)
            {
                imgMoeda.Source = "moeda_cara";
            }
            else
            {
                imgMoeda.Source = "moeda_coroa";
            }
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}