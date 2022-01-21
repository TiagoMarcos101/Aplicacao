using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacao.VC
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Pagenu : ContentPage
    {


        public void GetData(Dadosuser U)
        {

        }

        public Pagenu()
        {
            InitializeComponent();
        }
 
        async private void getdata(object sender, EventArgs e)
        {
            string pass = pw2.Text;
            string fname = name2.Text;

        
                await Navigation.PushAsync(new Pagelogin(), true);
            
        }

    }
}