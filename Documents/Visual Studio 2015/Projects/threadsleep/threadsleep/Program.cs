using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadsleep
{
    class threadsstart
    {
        static void Main(string[] args)
        {
            ThreadStart childref=new ThreadStart (c2childthread);
            Console.WriteLine("in main creating child thread");
            Thread childthread = new Thread(childref);
            childthread.Start();
            Console.ReadKey();
        }
        public static void c2childthread()
        {
            Console.WriteLine("child thread starts");
            int sleeptime = 5000;
            Console.WriteLine("child thread paused for {0} secs", sleeptime/1000);
            Thread.Sleep(sleeptime);
            Console.WriteLine("child thread resume");
        }
    }
}
