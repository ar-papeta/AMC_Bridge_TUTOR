using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionLength
{
    class ProjectionLength
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            int Ax = sequence_A[0];
            int Bx = sequence_A[2];
            int Cx = sequence_A[4];
            int Dx = sequence_A[6];
            if(Ax <= Bx && Ax <= Cx && Ax <= Dx)
            {
                if(Bx < Cx && Bx < Dx)
                {
                    Console.Write(0);
                }
                else if (Bx >= Cx && Bx >= Dx)
                {
                    Console.Write(Math.Abs(Cx - Dx));
                }
                else if (Bx >= Cx && Bx <= Dx)
                {
                    Console.Write(Math.Abs(Bx - Cx));
                }
                else if (Bx <= Cx && Bx >= Dx)
                {
                    Console.Write(Math.Abs(Bx - Dx));
                }

            }
            if (Bx <= Ax && Bx <= Cx && Bx <= Dx)
            {
                if (Ax < Cx && Ax < Dx)
                {
                    Console.Write(0);
                }
                else if (Ax >= Cx && Ax >= Dx)
                {
                    Console.Write(Math.Abs(Cx - Dx));
                }
                else if (Ax >= Cx && Ax <= Dx)
                {
                    Console.Write(Math.Abs(Ax - Cx));
                }
                else if (Ax <= Cx && Ax >= Dx)
                {
                    Console.Write(Math.Abs(Ax - Dx));
                }
            }
            if (Cx <= Bx && Cx <= Ax && Cx <= Dx)
            {
                if (Dx < Ax && Dx < Bx)
                {
                    Console.Write(0);
                }
                else if (Dx >= Ax && Dx >= Bx)
                {
                    Console.Write(Math.Abs(Ax - Bx));
                }
                else if (Dx >= Ax && Dx <= Bx)
                {
                    Console.Write(Math.Abs(Dx - Ax));
                }
                else if (Dx <= Ax && Dx >= Bx)
                {
                    Console.Write(Math.Abs(Dx - Bx));
                }
            }
            if (Dx <= Bx && Dx <= Cx && Dx <= Ax)
            {
                if (Cx < Ax && Cx < Bx)
                {
                    Console.Write(0);
                }
                else if (Cx >= Ax && Cx >= Bx)
                {
                    Console.Write(Math.Abs(Ax - Bx));
                }
                else if (Cx >= Ax && Cx <= Bx)
                {
                    Console.Write(Math.Abs(Cx - Ax));
                }
                else if (Cx <= Ax && Cx >= Bx)
                {
                    Console.Write(Math.Abs(Cx - Bx));
                }
            }
        }
    }
}
