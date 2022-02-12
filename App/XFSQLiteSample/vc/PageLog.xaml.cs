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
                    Pass = passUSR.Text,
                    QuantCoz = quantCozid.Text,
                    TipoCoz = combobox.SelectedIndex
                });
                nomeUSR.Text = string.Empty;
                passUSR.Text = string.Empty;
                quantCozid.Text = string.Empty;
                combobox.SelectedIndex = -1;
                
                

                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }else
            {
              await  DisplayAlert("Erro", "Por Favor insira os seus dados de login", "Tentar de novamente");
            }
        }
        async private void PageAdm(object sender, EventArgs e)
        {
           await DisplayAlert("", "Atenção esta página é só para admins", "Compreendo");
           await Navigation.PushAsync(new PageVefAdm(), true);
        }
    }
}