using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlignedBoundingBox
{
    class AlignedBoundingBox
    {
        static void Main(string[] args)
        {
            List<Double> sequence_A = new List<Double>();
            List<Point> point = new List<Point>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToDouble(input_A[i]));
            }
            int pointCount = (int)sequence_A[0];
            sequence_A.RemoveAt(0);
            int j = 0;
            for (int i = 0; i < pointCount; i++)
            {
                point.Add(new Point(sequence_A[j++], sequence_A[j++], sequence_A[j++]));
            }
            Double X_min = point[0].X;
            Double X_max = point[0].X;
            Double Y_min = point[0].Y;
            Double Y_max = point[0].Y;
            Double Z_min = point[0].Z;
            Double Z_max = point[0].Z;
            foreach (Point p in point)
            {
                if (p.X < X_min)
                    X_min = p.X;
                if (p.X > X_max)
                    X_max = p.X;
                if (p.Y < Y_min)
                    Y_min = p.Y;
                if (p.Y > Y_max)
                    Y_max = p.Y;
                if (p.Z < Z_min)
                    Z_min = p.Z;
                if (p.Z > Z_max)
                    Z_max = p.Z;
            }
            Console.Write(X_min + " " + Y_min + " " + Z_min + " " + X_max + " " + Y_max + " " + Z_max);
        }
    }
    class Point
    {
        public Double X {  get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }
        public Point(Double x, Double y, Double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

    }
}
