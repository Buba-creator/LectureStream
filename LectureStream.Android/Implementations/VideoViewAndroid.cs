using System;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LectureStream.Droid.Implementations;
using LectureStream.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.Android;
using View = Xamarin.Forms.View;

[assembly:ExportRenderer(typeof(LectureStream.VideoView),typeof(VideoViewAndroid))]

namespace LectureStream.Droid.Implementations
{
    public class VideoViewAndroid :ViewRenderer,ISurfaceHolderCallback,MediaPlayer.IOnPreparedListener
    {
        SurfaceView surfaceView;
        private readonly Context _context;
        public VideoViewAndroid(Context context):base(context)
        {
           
           
        }
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {

            base.OnElementChanged(e);

           
            if (Control != null)
            {
                Android.Widget.VideoView videoView = new Android.Widget.VideoView(Context);            
                SetNativeControl(videoView);
            }

            if (e.OldElement != null)
            {
              
            }
            if (e.NewElement != null)
            {
               
            }

        }

        private ISurfaceHolder surfaceHolder;
        private MediaPlayer mediaPlayer = new MediaPlayer();





        public void OnPrepared(MediaPlayer mp)
        {

        }

        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
            throw new NotImplementedException();
        }


        public void SurfaceCreated(ISurfaceHolder holder)
        {

        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }


    }
}
