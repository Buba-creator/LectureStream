using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using LectureStream.Models;
using LectureStream.Services;
using LectureStream.Views;
using Xamarin.Forms;

namespace LectureStream.ViewModel
{
    public class PlayPageViewModel:BaseViewModel
    {
        public bool YourChoiceLoading { get; set; }
        public bool YourChoiceLoaded { get; set; }
        public List<Album> AllLectures { get; set; } = new List<Album>
        {
           new Album
           {
                thumbnailUrl="edf1"

           },
           new Album
           {
                thumbnailUrl="wsd2"

           },
           new Album
           {
                thumbnailUrl="qwsd4"

           },
           new Album
           {
                thumbnailUrl="dsf3"

           }
        };

        public string Album { get; set; }
        public PlayPageViewModel()
        {
            //AllLectures = restService.GetLectures();
        }
        public List<Album>Recommended { get; set; } = new List<Album>
        {
           new Album
           {
                thumbnailUrl="edf1"

           },
           new Album
           {
                thumbnailUrl="wsd2"

           },
           new Album
           {
                thumbnailUrl="qwsd4"

           },
           new Album
           {
                thumbnailUrl="dsf3"

           }
        };

    }
}
