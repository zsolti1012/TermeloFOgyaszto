using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace sakkos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sakk sakk1 = new Sakk();
            Thread t1 = new Thread(sakk1.Kirajzolfelül);
            Thread t2 = new Thread(sakk1.Kirajzolalul);

            t1.Start();
            t2.Start();
            Console.ReadLine();
            
        }
    }
}
