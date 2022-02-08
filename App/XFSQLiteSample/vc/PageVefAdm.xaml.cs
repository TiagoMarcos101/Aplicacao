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
    public partial class PageVefAdm : ContentPage
    {
        public PageVefAdm()
        {
            InitializeComponent();
        }



        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(pass.Text) && pass.Text == "7214")
            {
                await Navigation.PushAsync(new PageAdm(), true);

            }else
            {
               await DisplayAlert("", "Se fores um administrador volta a inserir a palavra passe se não fores administrador não tente entrar", "Ok");
            }
        }


    }
}