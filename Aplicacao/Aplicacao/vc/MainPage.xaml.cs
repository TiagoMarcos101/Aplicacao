using System;
using Xamarin.Forms;
using MongoDB.Driver;
using Aplicacao;
namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string Mongoconnection = "mongodb://Jacare:vermelho2004@cluster0-shard-00-00.flr0m.mongodb.net:27017,cluster0-shard-00-01.flr0m.mongodb.net:27017,cluster0-shard-00-02.flr0m.mongodb.net:27017/pap?ssl=true&replicaSet=atlas-13durq-shard-0&authSource=admin&retryWrites=true&w=majority";
        public static string MongoDatabase = "pap";


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
       internal static void Mongoconn(object sender, EventArgs e)
        {
                 
            try
            {

                client = new MongoClient(Mongoconnection);
                database = client.GetDatabase(MongoDatabase);

            }
            catch (Exception)
            {
                throw;
            }
            




        }    
    }
}