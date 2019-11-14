using System;
using Xamarin.Forms;

namespace LectureStream.Interfaces
{
    public interface IVideoPlayer
    {
        void Dispose();

        bool LoadScreen(View view,float PageHeight,string uri);

        void FullScreen(float Width,float height);

        void SeekTo();

        void SeekBack();

        void MultiTask();
        
    }
}
