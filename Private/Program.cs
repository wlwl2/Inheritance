// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance

// Private members are visible only in derived classes that are nested in their
// base class.

using System;

namespace Inheritance
{
    public class A
    {
        // private member
       private int value = 10;

       // derived class B nested in base class A
       public class B : A
       {
           public int GetValue()
           {
               return this.value;
           }
       }
    }

    // if you add the C.GetValue method and attempt to
    // compile the example, it produces compiler error CS0122: "'A.value' is
    // inaccessible due to its protection level."
    public class C : A
    {
       public int GetValue()
       {
           return this.value;
       }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue()); // 10

        }
    }
}
