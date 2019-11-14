using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Input;
using LectureStream.Interfaces;
using LectureStream.Models;
using LectureStream.Services;
using LectureStream.Views;
using Xamarin.Forms;

namespace LectureStream.ViewModel
{
    public class HomeViewModel : BaseViewModel
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

        public HomeViewModel()
        {
            //AllLectures =restService.GetLectures();

        }
        public List<Album> Recents {get;set;} = new List<Album>
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


        public List<Album> YourChoice { get; set; } = new List<Album>
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


        public List<Album> MostViewed { get; set; } = new List<Album>
        {
           new Album
           {
                thumbnailUrl="This is 1"

           },
           new Album
           {
                thumbnailUrl="This is 2"

           },
           new Album
           {
                thumbnailUrl="This is 3"

           },
           new Album
           {
                thumbnailUrl="This is 4"

           }
        };


    }
}

