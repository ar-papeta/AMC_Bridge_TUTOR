using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
       
            String str = Console.ReadLine();
            double l = Convert.ToDouble(str);
            double r = 0;
            double s = 0;
            r = l / (2 * Math.PI);
            s = Math.PI * Math.Pow(r, 2);
            Console.Write(s);

        }
    }
}
