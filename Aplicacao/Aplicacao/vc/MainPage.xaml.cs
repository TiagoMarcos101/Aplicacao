using System;
using Xamarin.Forms;
using MySqlConnector;
namespace Aplicacao.VC
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();


        }
        async private void Paglogin(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Pagenu(), true);
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
        async private void Mysqlconn(object sender, EventArgs e)
        {

            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "Server = 127.0.0.1; Port = 3307; Database = universidade; Uid = root; Pwd = root";
                //This is my insert query in which i am taking input from the user through windows forms  
                //string Query = "insert into student.studentinfo(idStudentInfo,Name,Father_Name,Age,Semester) values('" + this.IdTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.FnameTextBox.Text + "','" + this.AgeTextBox.Text + "','" + this.SemesterTextBox.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
               // MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
               // MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                Console.WriteLine("Save Data");
              //  while (MyReader2.Read())
             ///   {
               // }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
