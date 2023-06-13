using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw7
{
    public class StudentCollection<T> : IStudentCollection<T> where T : Student
    {
        private List<T> collection;
        public StudentCollection()
        {
            collection = new List<T>();
        }
        public void Add(T course)
        {
            collection.Add(course);
        }
        public bool Remove(T course)
        {
            return collection.Remove(course);
        }
        public int IndexOf(T course)
        {
            return collection.IndexOf(course);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}