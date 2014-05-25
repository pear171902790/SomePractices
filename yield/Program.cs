using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new object[] { "aa", 2, true, "bb", DateTime.Now };
            var enumrable = new Enumerable(objects);
            foreach (var obj in enumrable)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }

    public class Enumerable : IEnumerable
    {
        private object[] _objects;

        public Enumerable(object[] objects)
        {
            _objects = objects;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _objects.GetEnumerator();
        }
    }
}
