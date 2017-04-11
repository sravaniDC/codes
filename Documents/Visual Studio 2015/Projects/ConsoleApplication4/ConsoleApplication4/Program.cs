using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class bubblesort
    {
        static void Main(string[] args)
        {
            
                int[] a = { 3, 2, 5, 4, 1 };
                int temp;
                Console.WriteLine("The Array is : ");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    for (int i = 0; i <= a.Length -1 ; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            temp = a[i + 1];
                            a[i + 1] = a[i];
                            a[i] = temp;
                        }
                    }
                }
                Console.WriteLine("The Sorted Array is:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
        }
}
