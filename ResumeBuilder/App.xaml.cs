using System;
using ResumeBuilder.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResumeBuilder
{
    public partial class App : Application
    {
        static UserDB database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
         }


        public static UserDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserDB(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("User.db3"));
                }
                return database;
            }
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
