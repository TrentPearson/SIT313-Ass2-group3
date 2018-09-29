using System;
using System.Collections.Generic;
using ResumeBuilder.Data;
using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public partial class MyResumes : ContentPage
    {
        public string actualUser;
        public MyResumes(string u)
        {
            actualUser = u;
            InitializeComponent();
            
        }

        private async void backBtn(object sender, System.EventArgs e)
        {

            await Navigation.PushModalAsync(new HomePage(actualUser));
        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();

            resumeInfo.ItemsSource = await App.Database.GetUserAsync(actualUser);

        }
    }
}
