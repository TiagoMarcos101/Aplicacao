using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.Model;
using Xamarin.Forms;
using SQLitePCL;
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

       async private void Mysqlconn(object sender, EventArgs e)
        {
            SQLiteConnection GetConnection();
        }

    }
    }
       
