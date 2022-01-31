using System;
using Xamarin.Forms;
using MongoDB.Driver;
using Aplicacao;
namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
 
        public  MainPage()
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

        private void Mongoconn(object sender, EventArgs e)
        {
            try
            {


                ConnectMongoDB c = new ConnectMongoDB();
                c.ConnectToMongoService();
                Console.WriteLine("Connected To MongoDB");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Shit Happened");
                Console.WriteLine(ex.ToString());
            }

        }



    }
}