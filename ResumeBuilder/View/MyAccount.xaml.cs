using System;
using System.Collections.Generic;
using System.IO;
using ResumeBuilder.Data;
using SQLite;
using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public partial class MyAccount : ContentPage
    {
        public string actualUser;
        public MyAccount(string u)
        {
            actualUser = u;
            InitializeComponent();

        }

        private async void signOut(object sender, System.EventArgs e)
        {

            await Navigation.PushModalAsync(new MainPage());
        }

        private async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage(actualUser));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            UserListView.ItemsSource = await App.Database.GetUserAsync(actualUser);

        }
    }
}
