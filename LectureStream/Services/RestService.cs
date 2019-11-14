//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Net.Http;
//using System.Linq;
//using System.Threading.Tasks;
//using LectureStream.Interfaces;
//using LectureStream.Models;
//using Newtonsoft.Json;

//namespace LectureStream.Services
//{
//    public class RestService:IRestService
//    {
//        HttpClient httpClient;
//        public RestService()
//        {
//            httpClient = new HttpClient();
//        }

//        public async Task<List<Courses>> GetCourses()
//        {
//            var uri = new Uri("Endpoint");
//            var Response = await httpClient.GetAsync(uri);
//            if (Response.IsSuccessStatusCode)
//            {
//                var Content = await Response.Content.ReadAsStringAsync();
//                var Courses = JsonConvert.DeserializeObject<List<Courses>>(Content);
//                return Courses;
//            }
//            return null;
//        }

//        public async Task<List<Lectures>> GetLectures()
//        {
//            var uri = new Uri("Endpoint");
//            var Response = await httpClient.GetAsync(uri);
//            if (Response.IsSuccessStatusCode)
//            {
//                var Content = await Response.Content.ReadAsStringAsync();
//                var  Lectures = JsonConvert.DeserializeObject<List<Lectures>>(Content);
//                return  Lectures;
//            }
//            return null;
//        }

//        public async Task<List<Lectures>> GetMostWatchedLectures()
//        {
//            var uri = new Uri("Endpoint");
//            var Response = await httpClient.GetAsync(uri);
//            if (Response.IsSuccessStatusCode)
//            {
//                var Content = await Response.Content.ReadAsStringAsync();
//                var Lectures = JsonConvert.DeserializeObject<List<Lectures>>(Content);
//                return Lectures;
//            }
//            return null;
//        }

//        public async Task<List<Lectures>> GetRecentLectures()
//        {
//            var uri = new Uri("Endpoint");
//            var Response = await httpClient.GetAsync(uri);
//            if (Response.IsSuccessStatusCode)
//            {
//                var Content = await Response.Content.ReadAsStringAsync();
//                var Lectures = JsonConvert.DeserializeObject<ObservableCollection<Lectures>>(Content);
//                var recents = from Lecture in Lectures orderby Lecture.Venue select Lecture;
//                return recents.ToList();
//            }
//            return null;
//        }
//    }
//}
