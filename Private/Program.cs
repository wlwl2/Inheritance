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
