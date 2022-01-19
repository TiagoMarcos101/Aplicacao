using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacao.vc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagenu : ContentPage
    {
        public Pagenu()
        {
            InitializeComponent();
        }
        async private void getdata(object sender, EventArgs e)
        {
            string pass = pw2.Text;
            string fname = name2.Text;
            if (pass == "123" && fname == "jose")
            { 
                await Navigation.PushAsync(new Pagelogin(), true);
            }
        }
    }
}