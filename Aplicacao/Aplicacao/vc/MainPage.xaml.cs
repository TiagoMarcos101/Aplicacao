using System;
using Xamarin.Forms;
using MongoDB.Driver;
using Aplicacao;
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

        private void Mongoconn(object sender, EventArgs e)
        {
           
            var settings = MongoClientSettings.FromConnectionString("mongodb://Jacare:vermelho2004cluster0-shard-00-00.flr0m.mongodb.net:27017,cluster0-shard-00-01.flr0m.mongodb.net:27017,cluster0-shard-00-02.flr0m.mongodb.net:27017/pap?ssl=true&replicaSet=atlas-13durq-shard-0&authSource=admin&retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("pap");
            var dbList = client.ListDatabases().ToList();
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }

        }



    }
}