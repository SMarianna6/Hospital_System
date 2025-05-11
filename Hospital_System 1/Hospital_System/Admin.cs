using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public static class Admin
    {
        public static IEnumerable<T> GetEntities<T>(string path) where T : IAdmin, new()
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var entity = new T();
                entity.Parse(line);
                yield return entity;
            }
        }
    }
}
