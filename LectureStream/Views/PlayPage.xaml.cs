using System;
using System.Collections.Generic;
using LectureStream.Interfaces;
using LectureStream.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LectureStream.Views
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class PlayPage : ContentPage
    {
        public PlayPage(Album album)
        {
            InitializeComponent();
            BindingContext = new PlayPageViewModel() {Album=album.thumbnailUrl};
            var connection = DependencyService.Get<ISQLiteDB>().GetConnection();
            connection.Insert(album);
        }

        protected override void OnAppearing()
        {      
            VideoView.WidthRequest = DeviceDisplay.MainDisplayInfo.Width;           
            DependencyService.Get<IVideoPlayer>().LoadScreen(VideoView.Content,
            (float)Application.Current.MainPage.Width,
            "https://archive.org/download/BigBuckBunny_328/BigBuckBunny_512kb.mp4");           
            base.OnAppearing();
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            var Gesture = (sender as Frame).GestureRecognizers[0] as TapGestureRecognizer;
              var album=  Gesture.CommandParameter as Album;
            await Navigation.PushModalAsync(new PlayPage(album));
        }

        void BackButton(object sender, System.EventArgs e)
        {
            DependencyService.Get<IVideoPlayer>().Dispose();
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}

