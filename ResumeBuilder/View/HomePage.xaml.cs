using System;
using System.Collections.Generic;
using ResumeBuilder.Data;
using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public partial class HomePage : ContentPage
    {
        public string currentUser;
        public string actualUser;

        public HomePage(string u)
        {
            currentUser = u;

            InitializeComponent();
        }

        private async void accountBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MyAccount(currentUser));
        }

        private async void createResume(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ResumeForm(currentUser){BindingContext = new User()});
        }

        private async void myResume(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MyResumes(actualUser));
        }
    }
}
