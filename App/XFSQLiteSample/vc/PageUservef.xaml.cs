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
    public partial class PageUservef : ContentPage
    {
        public PageUservef()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("Aviso", "Caso não encontre o seu nome de utilizador contacte o administrador ", "Compreendo");

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if (nameUSR != null)
            {
                collectionView.ItemsSource = await App.Database.GetUserAsync(nameUSR.Text);
            }else
            {
                await DisplayAlert("Erro", "Por favor insira o seu nome de utilizador", "Entendi");
            }
            }
    }
}