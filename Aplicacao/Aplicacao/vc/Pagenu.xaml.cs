using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Aplicacao.VC
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Pagenu : ContentPage
    {




        public Pagenu()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CollectionView collectionview = new CollectionView();
            collectionview.ItemsSource = await App.Database.GetUserAsync();
        }
        async void Getandsetdata(object sender, EventArgs e)
        {
            try {             CollectionView collectionview = new CollectionView();
                if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(passWd.Text))
                {
                    await App.Database.SaveUserAsync(new SQLDB
                    {
                        Passwd = passWd.Text,
                        Fname = name.Text


                    });
                    name.Text = string.Empty;
                    passWd.Text = string.Empty;
                    collectionview.ItemsSource = await App.Database.GetUserAsync();
               





                }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }





















        }


    }
    }
       
