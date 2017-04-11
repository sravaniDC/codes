using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace links
{
    class cdetails
    {
        static void Main(string[] args)
        {

            customer c1 = new customer()
            {
                id = 100,
                name = "asha",
                salary = 200000
            };
            List<customer> customers = new List<customer>(1);
            
                customers.Add(c1);
            Console.WriteLine("id={0},name={1},salary={2}", c1.id, c1.name, c1.salary);

        } 
        public class customer
        {
            public int id { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
        }
    }




}
