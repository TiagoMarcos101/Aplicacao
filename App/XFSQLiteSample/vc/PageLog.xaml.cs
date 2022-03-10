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
        protected override  void OnAppearing()
        {
            base.OnAppearing();
        }

        async void Login(object sender, EventArgs e)
        {
            
            string tipocoz = combobox.SelectedIndex.ToString();
            if (!string.IsNullOrWhiteSpace(nomeUSR.Text)  && !string.IsNullOrWhiteSpace(quantCozid.Text) && quantCozid.Text != "0" )
            {
            
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nomeUSR.Text,
                    QuantCoz = Int16.Parse(quantCozid.Text),
                    TipoCoz = combobox.SelectedIndex,
                    Time = DateTime.Now.ToString("hh:mm:ss tt")
            });
                await DisplayAlert("Aviso", "Atenção ao registar seus dados, quando for verificar, saiba que se colocar letras maiúsculas, acentos ou caracteres especiais vai ter que os colocar ", "Compreendo");
                nomeUSR.Text = string.Empty;
                quantCozid.Text = string.Empty;
                combobox.SelectedIndex = -1;
                
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
               await DisplayAlert("Sucesso", "Cozido registado com sucesso","Comfirmar");
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
                
            }else
            {
              await  DisplayAlert("Erro", "Por Favor insira os dados para registar o seu cozido", "Tentar de novamente");
            }
        }
        async private void PageAdm(object sender, EventArgs e)
        {
           await DisplayAlert("", "Atenção esta página é só para admins", "Compreendo");
           await Navigation.PushAsync(new PageVefAdm(), true);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageUservef(), true);
        }
    }
}