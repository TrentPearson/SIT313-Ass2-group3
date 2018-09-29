using System;
using System.Collections.Generic;
using ResumeBuilder.Data;
using Xamarin.Forms;
using ResumeBuilder;

namespace ResumeBuilder.View
{
    public partial class ResumeForm : ContentPage
    {
        public string actualUser;
        public ListView resitem;

        public ResumeForm(string u)
        {
            actualUser = u;
            InitializeComponent();
            //actualUser = ResumeBuilder.Data.User.CurrentUser;
        }


        private async void saveBtn(object sender, System.EventArgs e)
        {


                var resItem = (User)BindingContext;
                await App.Database.SaveUserAsync(resItem);
                await Navigation.PushModalAsync(new MyResumes(actualUser));

        }

        private async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage(actualUser));
        }
    }
}
