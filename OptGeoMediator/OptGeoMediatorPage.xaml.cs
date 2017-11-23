using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Diagnostics;

namespace OptGeoMediator
{
    public partial class OptGeoMediatorPage : ContentPage
    {

        Map map;

        public OptGeoMediatorPage()
        {
            map = new Map
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(36.9628066, -122.0194722), Distance.FromMiles(3))); // Santa Cruz golf course
            
            var NewAction = new Button { Text = "Action" };
            NewAction.Clicked += (sender, e) => AddActionBtn(sender, e);


            var buttons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    NewAction
                }
            };

            // put the page together
            Content = new StackLayout
            {
                Spacing = 0,
                Children = {
                    map,
                    buttons
                }
            };
        }

        public void AddActionBtn(object sender, EventArgs e){
            this.Navigation.PushModalAsync(new ActionPage());
        }
    }
}
