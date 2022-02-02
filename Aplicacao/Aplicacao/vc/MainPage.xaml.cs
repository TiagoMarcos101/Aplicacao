using System;
using Xamarin.Forms;
using Aplicacao;

namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
 
        public  MainPage()
        {
            InitializeComponent();


        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CollectionView collectionview = new CollectionView();            
            collectionview.ItemsSource = await App.Database.GetUserAsync();
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

        private void DB(object sender, EventArgs e)
        {


        }
    }
}