// Derived classes can also override inherited members by providing an alternate
// implementation. In order to be able to override a member, the member in the
// base class must be marked with the `virtual` keyword. By default, base class
// members are not marked as `virtual` and cannot be overridden. Attempting to
// override a non-virtual member, as the following example does, generates
// compiler error CS0506: " cannot override inherited member because it is not
// marked virtual, abstract, or override.

﻿using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClassExample example1 = new DerivedClassExample();
            example1.ExampleMethod1();
        }
    }

    public class BaseClassExample
    {

        // public virtual void ExampleMethod1()
        public void ExampleMethod1()
        {
            // Do something.
            Console.Write("A");
        }
    }

    public class DerivedClassExample : BaseClassExample
    {
        public override void ExampleMethod1() // Generates CS0506.
        {
            // Do something else.
            Console.Write("B");
        }
    }

}
