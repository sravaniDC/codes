using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpllections
{
    class program
    { 
    static void Main(string[] args)
    {
        customer c1 = new customer()
        {
            id = 100,
            name = "asha",
            salary = 200000
        };
        customer[] customers = new customer[2];
            customers[0] = c1;
            customer c = customers[0];
            Console.WriteLine("id={0},name={1},salary={2}", c.id, c.name, c.salary);

    }
    public class  customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
    } 
    }




}
