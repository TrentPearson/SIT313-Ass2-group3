using System;

using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public class MyAccount : ContentPage
    {
        public MyAccount()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

