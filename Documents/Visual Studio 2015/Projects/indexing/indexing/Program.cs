using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexing
{
    public class employee
    {
        int eno;
        string ename, job, dname, location;
        double salary;

        public employee(int eno, string ename, string job, string dname, string location, double salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.job = job;
            this.dname = dname;
            this.location = location;
            this.salary = salary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return eno;
                else if (index == 1)
                    return ename;
                else return null;

            }
            set
            {
                if (index == 0)
                    eno = (int)value;
                else if (index == 1)
                    ename = (string)value;
            }
        }
      
    class program
        {
            static void Main(string[] args)
            {
                employee emp = new indexing.employee(143, "shravs", "artist", "arts", "banglore", 300000);
                Console.WriteLine("eno:" + emp[0]);
                Console.ReadLine();
                emp[0] = 200;
                Console.WriteLine("eno:" + emp[0]);

            }
        }
    }
}
