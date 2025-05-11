using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class SearchMetod<T> where T : IEntity
    {
        private static List<T> entities = new List<T>();

        public static void Add(T entity)
        {
           entities.Add(entity);
        }

        // Task 1. LINQ to perform complex searching
        public static IEnumerable<T> Search(string searchString)
        {
           return entities.Where(it => it.Search(searchString));
        }

        public static void Clear()
        {
           entities.Clear();
        }
    }
}
