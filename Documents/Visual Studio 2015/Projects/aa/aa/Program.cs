using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main()
        {
            var demo = new AsyncAwaitDemo();
            demo.Display();

            while (true)
            {
                Console.WriteLine("processing please wait");
            }
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task Display()
        {
            await Task.Run(() =>
            {
                LongRunningOperation();
            });
        }

        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 500; counter++)
            {
                Console.WriteLine(counter);
            }

            return "Counter = " + counter;
        }
    }
}
