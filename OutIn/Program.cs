using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutIn
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest<Chinese> cs=new Test<Chinese>();
            ITest<Person> ps = cs;
            Beta<Person> b = (p => Console.WriteLine(p.Name));
            b(new Chinese());
            Console.WriteLine(new Chinese().Name);
            Console.ReadLine();
        }
    }
    public class Person
    {
        public  string Name = "Person";
    }
    public class Chinese:Person
    {
        public new string Name = "Chinese";
    }

    public delegate void Beta<in T>(T obj);

    public interface ITest<out T>
    {
        
    }
    public class Test<T>:ITest<T>
    {
        
    }
    
}
