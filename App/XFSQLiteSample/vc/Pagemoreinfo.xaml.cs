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
    public partial class Pagemoreinfo : ContentPage
    {
        public Pagemoreinfo()
        {
            InitializeComponent();
        }

      async  private void Button_Clicked(object sender, EventArgs e)
        {
            collectionView.ItemsSource = await App.Database.GetCountcoz();
        }
    }
}