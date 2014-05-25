using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = TestFactory.GetSingleTest();
            //var b = TestFactory.GetSingleTest();
            var a = Test.Instance;
            var b = Test.Instance;
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.ReadLine();
        }
    }

    public class Test
    {
        static Test _test = new Test();

        private Test()
        {
        }

        public static Test Instance
        {
            get { return _test; }
        }
    }

    //public class TestFactory
    //{
    //    private static Test _test = null;

    //    private static object _myLock = new Object();
    //    public static Test GetSingleTest()
    //    {
    //        if (_test == null)
    //        {
    //            lock (_myLock)
    //            {
    //                if (_test == null)
    //                {
    //                    _test=new Test();
    //                }
    //            }
    //        }
    //        return _test;
    //    }
    //}
}
