using System;
using System.Collections.Generic;
using LectureStream.Interfaces;
using LectureStream.ViewModel;
using Xamarin.Forms;

namespace LectureStream.Views
{
    public partial class HomeView : ContentView
    {
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {

            var Gesture = (sender as Frame).GestureRecognizers[0] as TapGestureRecognizer;
            var album = Gesture.CommandParameter as Album;
            await Navigation.PushModalAsync(new PlayPage(album));
        }
    }
}
 
