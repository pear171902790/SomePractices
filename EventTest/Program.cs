using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.MyEvent += b.DoB;
            a.MyEvent += b.DoBB;
            a.MyEvent -= b.DoB;
            var list = a.Get(new []
                {
                    1, 2, 3, 4, 5
                }
                );
            var list1 = list;
            


            a.DoA();

            //int[] arr ={81,31,21,24,55,99,15};
            //for (var j = 0; j < arr.Length; j++)
            //{
            //    for (var i = 0; i < arr.Length - j-1; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            var temp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = temp;
            //        }
            //    }
            //}
            //arr.ToList().ForEach(a=>Console.WriteLine(a));

            


            Console.ReadLine();
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string X { get; set; }
        public string Y { get; set; }
    }

    public class A
    {
        public Action<string> MyEvent;

        public void DoA()
        {
            OnMyEvent("nihao,jack");
        }

        void OnMyEvent(string str)
        {
            var temp = Interlocked.CompareExchange(ref MyEvent, null, null);
            if (temp != null)
            {
                temp(str);
            }
        }

        public IEnumerable<int> Get(int[] arr)
        {
            foreach (var i in arr)
            {
                yield return i;
            }
        }
    }

    public class B
    {
        public void DoB(string str)
        {
            Console.WriteLine(str);
        }

        public void DoBB(string str)
        {
            Console.WriteLine("zheshidobb"+str);
        }
    }
}
