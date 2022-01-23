using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacao.VC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagelogin : ContentPage
    {
        public Pagelogin()
        {
            InitializeComponent();


        }
        async private void Pagelogin1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }
       async private void getdata(object sender, EventArgs e)
        {
            string text1 = name.Text;
            string text2 = pw.Text;
            if(text1 == "jose")
            {
                    textfield.Text = "deu certo";
                // await Navigation.PushAsync(new MainPage(), true);
                Console.WriteLine("ola");

                
            }
        }
    }
}