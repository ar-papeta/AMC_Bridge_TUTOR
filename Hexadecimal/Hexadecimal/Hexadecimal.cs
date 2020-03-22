using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal
{
    class Hexadecimal
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(String.Format("{0:x}", number));
            //Console.ReadKey();
        }
    }
}
