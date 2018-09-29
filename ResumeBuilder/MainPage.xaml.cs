using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ResumeBuilder.Data;
using ResumeBuilder.View;
using SQLite;
using Xamarin.Forms;

namespace ResumeBuilder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

    private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateAccount(){BindingContext = new User()});
        }

        private async void loginBtn(object sender, System.EventArgs e)
        {
            string uname = US.Text;
            string pass = PW.Text;
            List<User> a = await App.Database.GetUserAsync(uname);
            List<User> b = await App.Database.GetUserAsync(pass);




            if (a.Count() == 0) //then fail // no account
            {
                await DisplayAlert("ERROR", "email is wrong", "OK");
            }


            else if (a.Count() == 1 && pass != null && pass.Equals(a[0].Password))
            {

                await Navigation.PushModalAsync(new HomePage(uname));
                ResumeBuilder.Data.User.CurrentUser = uname;


            }
            else
            {
                await DisplayAlert("ERROR", "wrong password", "OK");
            }

        }
    }
}


