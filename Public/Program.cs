using System;

namespace Public
{
    public class BaseClassExample
    {
        public void Method1()
        {
            // Method implementation.
            Console.Write("DerivedClassExample inherits from BaseClassExample");
        }
    }

    public class DerivedClassExample : BaseClassExample
    { }


    public class Example
    {
        public static void Main()
        {
            DerivedClassExample derivedClassExample = new DerivedClassExample();
            derivedClassExample.Method1();
        }
    }
}
