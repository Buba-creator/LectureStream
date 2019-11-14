using System;
using SQLite;

namespace LectureStream.Interfaces
{
    public interface ISQLiteDB
    {
        SQLiteConnection GetConnection();

    }
}
