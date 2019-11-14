using System;
using AVFoundation;
using AVKit;
using Foundation;
using LectureStream.Interfaces;
using LectureStream.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(VideoPlayer))]
namespace LectureStream.iOS
{
    public class VideoPlayer:ViewRenderer<View,UIView>,IVideoPlayer
    {

        AVPlayer avplayer = new AVPlayer();
        AVPlayerLayer avplayerLayer;
        AVAsset avasset;
        AVPlayerItem avplayerItem;
        AVPlayerViewController _playerViewController;       // solely for ViewController property
        public override UIViewController ViewController => _playerViewController;

        public bool IsPlaying { get; set; }

        bool IVideoPlayer.LoadScreen(Xamarin.Forms.View view, float screenWidth,string uri)
        {

            var Uiview = (view as NativeViewWrapper).NativeView;
            avasset = AVAsset.FromUrl(NSUrl.FromString(uri));
            avplayerItem = new AVPlayerItem(avasset);
            avplayer = new AVPlayer(avplayerItem);
            _playerViewController = new AVPlayerViewController { Player = avplayer };
            avplayerLayer = AVPlayerLayer.FromPlayer(_playerViewController.Player);
            Uiview.Layer.AddSublayer(avplayerLayer);
            avplayerLayer.Frame = new CoreGraphics.CGRect(0,0,screenWidth, 260);          
            _playerViewController.ShowsPlaybackControls = true;
            _playerViewController.Player.Play();
            IsPlaying = true;
            return true;
           
        }

        public new void Dispose()
        {
            avplayer.Dispose();
        }

        public void FullScreen(float Width, float height)
        {
        }

        public void SeekTo()
        {
        }

        public void SeekBack()
        {
        }

        public void MultiTask()
        {
        }
    }
}
//Right around here I wanted to use reflection
//Later use Reflection to Change Uiview Layer to custom layer
//PropertyInfo uiview = typeof(UIView)
//   .GetProperty("Layer", BindingFlags.Instance | BindingFlags.Public|BindingFlags.SetField);
//uiview.SetValue(Uiview, avplayerLayer);