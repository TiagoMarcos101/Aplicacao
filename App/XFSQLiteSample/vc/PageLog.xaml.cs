using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFSQLiteSample.vc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLog : ContentPage
    {
        CollectionView collectionView = new CollectionView();
        public PageLog()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void Login(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nomeUSR.Text) && !string.IsNullOrWhiteSpace(passUSR.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nomeUSR.Text,
                    Pass = passUSR.Text
                });

                nomeUSR.Text = string.Empty;
                passUSR.Text = string.Empty;

                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }else
            {
              await  DisplayAlert("Erro", "Por Favor insira os seus dados de login", "Tentar de novamente");
            }
        }
    }
}