using Aplicacao.VC;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace Aplicacao
{
    public partial class App : Application
    {
        private static Database database;
        static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "data.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
