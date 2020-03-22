using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwo3DPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] point1 = new double[3];
            double[] point2 = new double[3];
            string input = Console.ReadLine();
            String[] _input = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i=0;i<2*point1.Length;i++)
            {
                if(i < 3)
                    point1[i] = Convert.ToDouble(_input[i]);
                if (i >= 3)
                    point2[i-3] = Convert.ToDouble(_input[i]);
            }
            double distance = Math.Sqrt(Math.Pow((point1[0] - point2[0]), 2) + Math.Pow((point1[1] - point2[1]), 2) + Math.Pow((point1[2] - point2[2]), 2));
            Console.Write(distance);
            //Console.ReadLine();

        }
    }
}
