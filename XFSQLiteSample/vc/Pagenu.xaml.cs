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
    public partial class Pagenu : ContentPage
    {
        public Pagenu()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                });

                nameEntry.Text = string.Empty;
                password.Text = string.Empty;


            }
            
        }
    }
}