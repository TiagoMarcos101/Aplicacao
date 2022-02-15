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
    public partial class PageAdm : ContentPage
    {
        public PageAdm()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        Person lastSelection;
        void collectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            lastSelection = e.CurrentSelection[0] as Person;
            nomeUSR.Text = lastSelection.Name;
        }
        // Atualizar
        async void Button_Clicked_1(object sender, EventArgs e)
        {
           if(lastSelection != null)
            {
                lastSelection.Name = nomeUSR.Text;
             await App.Database.UpdatePersonAsync(lastSelection);
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
                nomeUSR.Text = string.Empty;
            }
           else
            {
                await DisplayAlert("Erro", "Por favor selecione algum utilizador para atualizar", "Ok");
            }
        }
        //Apagar utilizador
     async   private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (lastSelection != null)
            {
                
                await App.Database.DeletePersonAsync(lastSelection);
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
            else
            {
                await DisplayAlert("Erro", "Por favor selecione algum utilizador para apagar", "Ok");
            }
        }
        // Quem tem cozidos
       async private void Button_Clicked_3(object sender, EventArgs e)
        {
            collectionView.ItemsSource = await App.Database.Query2Async();

        }
        // Quem não tem cozidos
       async private void Button_Clicked_4(object sender, EventArgs e)
        {
            collectionView.ItemsSource = await App.Database.Query3Async();

        }

    }
}