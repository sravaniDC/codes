using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

   
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static void Main()
        {
            bool Equal = C.AreEqual<int>(10, 20);
            if (Equal)

                Console.WriteLine("Equal");

            else

                Console.WriteLine("not equal");
            

        }
        public class C
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
    }
}
