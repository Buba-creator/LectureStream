using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LectureStream.Models;
using Xamarin.Forms;

namespace LectureStream.Interfaces
{
    public interface IRestService
    {
      Task<List<Lectures>> GetLectures();
      Task<List<Lectures>> GetRecentLectures();
    Task<List<Lectures>> GetMostWatchedLectures();
    Task<List<Courses>> GetCourses();
      
    }
}
