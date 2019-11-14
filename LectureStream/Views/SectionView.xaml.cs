using System;
using System.Collections.Generic;
using LectureStream.Interfaces;
using Xamarin.Forms;

namespace LectureStream.Views
{
    public partial class SectionView : ContentView
    {
        public SectionView()
        {
            InitializeComponent();
            var connection = DependencyService.Get<ISQLiteDB>().GetConnection();
            var Albums = connection.Table<Album>().ToList();
            History.ItemsSource = Albums;
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new PlayPage(new Album()));
        }
    }
}
