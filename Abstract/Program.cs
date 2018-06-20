using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public abstract class A
    {
        public abstract void Method1();
    }

    public class B : A // Generates CS0534.
    {
        public void Method3()
        {
            // Do something.
        }
    }
}
