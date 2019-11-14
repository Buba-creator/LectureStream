using SQLite;

namespace LectureStream.Views
{
    [Table("Albums")]
    public class Album
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
       
        public string title { get; internal set; }
        [MaxLength(90)]
        public string thumbnailUrl { get; internal set; }
        public string Url { get; internal set; }
    }
}