using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNarvaezEsteban
{
    internal class Database
    {
        public const string DBfilename = "consulta.db3";
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DBpath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBfilename);
            }

        }


    }
}