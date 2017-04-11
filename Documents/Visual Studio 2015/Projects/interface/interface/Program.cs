using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace interfacess
{
    interface MyInterface
    {
        void myMethod();
    }
    class MyClass : MyInterface
    {
        public static void Main()
        {
            MyClass cls = new MyClass();
            cls.myMethod();
        }
        public void myMethod()
        {
            Console.WriteLine("welcome to my world....");
            Console.ReadLine();
        }
    }
}