using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a=new Dog();
            a.A();

            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        public abstract void A();

    }

    public class Dog:Animal
    {
        public override void A()
        {
            Console.WriteLine("Dog");
        }
    }
}
