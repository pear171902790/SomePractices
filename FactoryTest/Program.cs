using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds=DoSomthingFactory.GetDoSomthing();
            ds.Do();
            Console.ReadLine();
        }
    }

    public interface IDoSomthing
    {
        void Do();
    }

    public static class DoSomthingFactory
    {
        public static IDoSomthing GetDoSomthing()
        {
            var className = System.Configuration.ConfigurationManager.AppSettings["DoSomthing"];
            var type = System.Type.GetType(className);
            return System.Activator.CreateInstance(type) as IDoSomthing;
        }
    }

    public class A : IDoSomthing
    {
        public void Do()
        {
            Console.WriteLine("aaaaaaaaaa");
        }
    }
    public class B : IDoSomthing
    {
        public void Do()
        {
            Console.WriteLine("bbbbbbbbbbbb");
        }
    }
}
