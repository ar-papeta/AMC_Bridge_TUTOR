using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int f = 1;
            int num = Convert.ToInt32(s);
            for(int i = 1; i <= num; i++)
            {
                f *= i;
            }
            Console.Write(f);
        }
    }
}
