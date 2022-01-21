using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {


            InitializeComponent();
            ConnectToMySQL();

        }
        async private void Paglogin(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new Pagelogin(), true);
        }
        async private void Pagnu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagenu(), true);
        }
        private void Pagenu_Clicked(object sender, EventArgs e)
        {

        }

        private void Pagenu_Clicked_1(object sender, EventArgs e)
        {

        }
        static void ConnectToMySQL()
        {
            MySqlConnection conn = null;
            var sb = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "root",
                Port = 3306,
                Database = "universidade"
            };

            try
            {
                Console.WriteLine(sb.ConnectionString);
                conn = new MySqlConnection(sb.ConnectionString);
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from test_table";
                var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Console.WriteLine("id={0}, value={1}", reader.GetInt32("id"), reader.GetString("value"));
                }
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
