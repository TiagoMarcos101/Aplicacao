using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSQLiteSample;
namespace XFSQLiteSample.vc
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
        InitializeComponent();
        }

        async private void Paglogin(object sender, EventArgs e)
        {

           // await Navigation.PushAsync(new Pagenu(), true);
        }
        async private void Pagenubtn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagenu(), true);
        }
        private void Pagenu_Clicked(object sender, EventArgs e)
        {

        }


    }
}