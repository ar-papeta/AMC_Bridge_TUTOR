using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String[] input_A = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double a = Convert.ToDouble(input_A[0]);
            double b = Convert.ToDouble(input_A[1]);
            double c = Convert.ToDouble(input_A[2]);
            double P = a + b + c;
            double p = P / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double R = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            Console.Write(P + " " + s + " " + R);
            //Console.ReadKey();
        }
    }
    
}
