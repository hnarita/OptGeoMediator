using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OptGeoMediator
{
    public partial class ActionPage : ContentPage
    {
        public ActionPage()
        {
            InitializeComponent();


        }

        public void OnClicked(object sender, EventArgs args){
            this.Navigation.PopModalAsync();
        }
    }
}
