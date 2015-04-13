using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Time is " + DateTime.Now.ToLocalTime());
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
