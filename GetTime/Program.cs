using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTime
{
    /// <summary>
    /// Displays the current date
    /// </summary>
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">This is command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Current Time is " + DateTime.Now.ToLocalTime());

            // single line comment

            /* Multi line
             * Block comment
             */


#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
