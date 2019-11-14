using System;
namespace LectureStream.Models
{
    public class Lectures
    {
        public string Topic { get; set; }
        public string Venue { get; set; }
        public string Course { get; set; }
        public string Link { get; set; }
        public string thumbnailUrl { get; set; }
        public double Duration { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
