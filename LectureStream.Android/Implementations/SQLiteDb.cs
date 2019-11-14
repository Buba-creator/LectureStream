using System;
using System.IO;
using LectureStream.Droid.Implementations;
using LectureStream.Interfaces;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace LectureStream.Droid.Implementations
{
    public class SQLiteDb:ISQLiteDB
    {       
        public SQLiteConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "MySQLite.db3");

            return new SQLiteConnection(path);
        }
    }
}
