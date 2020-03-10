using State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state

            c.Request();
  
            // Wait for user

            Console.ReadKey();

        }
    }
}
