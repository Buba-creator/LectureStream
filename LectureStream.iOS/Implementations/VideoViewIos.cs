using System;
using LectureStream.iOS.Implementations;
using LectureStream.Services;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(VideoView), typeof(VideoViewIos))]
namespace LectureStream.iOS.Implementations
{
    public class VideoViewIos
    {
        public VideoViewIos()
        {
        }
    }
}
