using System;
using System.Collections.Generic;
using System.IO;
using ResumeBuilder.Data;
using ResumeBuilder.View;
using SQLite;
using Xamarin.Forms;

namespace ResumeBuilder
{
    public partial class CreateAccount : ContentPage
    {

        public CreateAccount()
        {
            InitializeComponent();

        }
         async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void signup(object sender, System.EventArgs e)
        {

                var personItem = (User)BindingContext;

                await App.Database.SaveUserAsync(personItem);

                await Navigation.PushModalAsync(new MainPage());

        }
    }
}
