using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threads
{
    class thread

    {


        static void Main(string[] args)
        {
        
            Parallel.For(0, 1000, x => runmillioniteration()) ;
            Console.WriteLine("hellooo...");
   
            Console.Read();
        }
        private static void runmillioniteration()
        {
            string x = "";
            for (int iindex = 0; iindex < 1000; iindex++)
            {
                x = x + "s";
            }
        }
    }
}
