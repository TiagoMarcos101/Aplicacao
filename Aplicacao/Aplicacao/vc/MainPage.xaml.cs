using System;
using Xamarin.Forms;
namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();


        }
        async private void Paglogin(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Pagenu(), true);
        }
        async private void Pagnu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagenu(), true);
        }
        private void Pagenu_Clicked(object sender, EventArgs e)
        {

        }

        private void Pagenu_Clicked_1(object sender, EventArgs e)
        {

        }
       

    }
}
