using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public partial class ResumePreview : ContentPage
    {
        public ResumePreview()
        {
            InitializeComponent();
        }

        private async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }

        private async void addResume(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}
