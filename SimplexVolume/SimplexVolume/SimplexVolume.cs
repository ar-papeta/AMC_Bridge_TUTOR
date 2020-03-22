using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexVolume
{
    class SimplexVolume
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            List<Double> sequence_A = new List<Double>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToDouble(input_A[i]));
            }
            int j = 0;
            Vector a = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector b = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector d = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);

            Double SPV = 0;
            //Смешаное произведение векторов
            SPV = a.x * b.y * d.z + a.y * b.z * d.x + a.z * b.x * d.y - a.z * b.y * d.x - a.x * b.z * d.y - a.y * b.x * d.z;
            Console.Write(Math.Abs(SPV / 6));
            
          

        }
    }

    class Vector
    {
        public Double x { get; set; }
        public Double y { get; set; }
        public Double z { get; set; }
        public Vector(Double x, Double y, Double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
