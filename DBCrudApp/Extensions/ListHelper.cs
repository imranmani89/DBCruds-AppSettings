using DBCrudApp.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Extensions
{
    public static class ListHelper
    {
        public static decimal GetMiddleIndex<T>(this IEnumerable<T> list) where T : class
        {
            var middleIndex = Math.Ceiling((decimal) list.Count() / 2);
            return middleIndex;
        }

        public static int GetConnectionStringCount<TRepository>(this BaseRepository repository) where TRepository : BaseRepository
        {
            return repository._connectionString.Length;
        }
    }
}
