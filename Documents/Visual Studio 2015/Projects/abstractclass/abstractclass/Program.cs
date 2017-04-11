
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    class Hello
    {


        public abstract class Talk
        {
            public abstract void speak();


            public virtual void goodbye()
            {
                Console.WriteLine(" goodbye from talk class");

            }
        }

        public class SayHello : Talk
        {
            public override void speak()
            {
                Console.WriteLine("Hello!");
            }
        }

        static void Main()
        {
            SayHello hello = new SayHello();

            hello.speak();
            hello.goodbye();
        }
    }
}
