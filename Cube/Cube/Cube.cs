using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Cube
    {
        static void Main(string[] args)
        {
            int edge = Convert.ToInt32(Console.ReadLine());
            int volume = Convert.ToInt32(Math.Pow(edge, 3));
            int surface = Convert.ToInt32(6 * Math.Pow(edge, 2));
            Console.Write(volume+" "+surface);
            Console.ReadLine();
           
        }
    }
}
