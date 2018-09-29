using System;

using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public class Button : ContentPage
    {
        public Button()
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

