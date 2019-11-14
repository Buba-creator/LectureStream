using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LectureStream.Droid;
using LectureStream.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:Dependency(typeof(VideoPlayer))]

namespace LectureStream.Droid
{

    public class VideoPlayer:IVideoPlayer
    {      
        public string CurrentStream { get; set; }
        public int StopPosition { get; set; }
        MediaController mediaController;
        public VideoView videoView { get; set; }
        bool IVideoPlayer.LoadScreen(Xamarin.Forms.View view, float screenHeight, string uri)
        {
            videoView = (view as NativeViewWrapper).NativeView as VideoView;
            videoView.SetVideoURI(Android.Net.Uri.Parse(uri));
            videoView.Start();
            CurrentStream = uri;
            mediaController = new MediaController(videoView.Context);
            mediaController.SetMediaPlayer(videoView);
            videoView.SetMediaController(mediaController);
            for (int i = 0; i < 15; i++)
            {
                if (videoView.IsPlaying)
                    return true;

                return false;
            }
            return false;
        }
        public void PlayPause()
        {
        }
        public void Dispose()
        {
            videoView.Dispose();
        }

        public void FullScreen(float Width, float height)
        {          
        }

        public void MultiTask()
        {
        }

        public void SeekTo()
        {
        }

        public void SeekBack()
        {
        }

       
    }
}
