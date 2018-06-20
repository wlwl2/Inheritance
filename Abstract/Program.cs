using System;

// In some cases, a derived class must override the base class implementation.
// Base class members marked with the abstract keyword require that derived
// classes override them. Attempting to compile the following example generates
// compiler error CS0534, " does not implement inherited abstract member ',
// because class B provides no implementation for A.Method1.

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("`override` successful!");
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

        // public override void Method1()
        // {}
    }
}
