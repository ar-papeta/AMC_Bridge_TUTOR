using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPolygonConvex
{
    class IsPolygonConvex
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
            int verticesQuantity = (int)sequence_A[0];

            if (verticesQuantity == 3)
            {
                //Console.Write(1);
                //return;
            }
            else if (verticesQuantity < 3)
            {
                //Console.Write(0);
                //return;
            }

            sequence_A.RemoveAt(0);

            Vertices[] PolygonVertices = new Vertices[verticesQuantity];
            Vertices[] PolygonSides = new Vertices[verticesQuantity];


            for (int i = 0, j = 0; i < verticesQuantity; i++)
            {
                PolygonVertices[i] = new Vertices(sequence_A[j++], sequence_A[j++]);
            }

            for (int i = 0; i <= verticesQuantity - 1; i++)
            {
                if (i == verticesQuantity - 1)
                    PolygonSides[i] = new Vertices(PolygonVertices[0].x - PolygonVertices[i].x, PolygonVertices[0].y - PolygonVertices[i].y);
                else
                    PolygonSides[i] = new Vertices(PolygonVertices[i + 1].x - PolygonVertices[i].x, PolygonVertices[i + 1].y - PolygonVertices[i].y);
            }
            /*
                for (int i = 0; i <= verticesQuantity - 1; i++)
                {
                        for (int q = i + 2; q < verticesQuantity-1; q++)
                        {
                        if (checkIntersectionOfTwoLineSegments(PolygonVertices[i], PolygonVertices[i + 1], PolygonVertices[q], PolygonVertices[q + 1]))
                        {
                            Console.Write(0);
                            return;
                        }
                        }
                }
            */
            for (int i = 0; i <= verticesQuantity - 1; i++)
            {
                if (i == verticesQuantity - 1)
                    if (PolygonSides[i].x * PolygonSides[0].y - PolygonSides[i].y * PolygonSides[0].x < 0)
                    {
                        Console.Write(0);
                        return;
                    }
                    else
                    {
                        Console.Write(1);
                    }

                else
                    if (PolygonSides[i].x * PolygonSides[i + 1].y - PolygonSides[i].y * PolygonSides[i + 1].x < 0)
                {
                    Console.Write(0);
                    return;
                }
            }
        }

        //метод, проверяющий пересекаются ли 2 отрезка [p1, p2] и [p3, p4]

        private static bool checkIntersectionOfTwoLineSegments(Vertices p1, Vertices p2, Vertices p3, Vertices p4)
        {
            double Xa ;
            double A2;
            double A1 ;
            double b2;
            double b1 ;

            double Ya ;

            if (p2.x < p1.x)
            {

                Vertices tmp = p1;

                p1 = p2;

                p2 = tmp;

            }


            if (p4.x < p3.x)
            {

                Vertices tmp = p3;

                p3 = p4;

                p4 = tmp;

            }

            //проверим существование потенциального интервала для точки пересечения отрезков

            if (p2.x < p3.x)
            {

                return false; //ибо у отрезков нету взаимной абсциссы

            }

            //если оба отрезка вертикальные

            if ((p1.x - p2.x == 0) && (p3.x - p4.x == 0))
            {

                //если они лежат на одном X

                if (p1.x == p3.x)
                {

                    //проверим пересекаются ли они, т.е. есть ли у них общий Y

                    //для этого возьмём отрицание от случая, когда они НЕ пересекаются

                    if (!((Math.Max(p1.y, p2.y) < Math.Min(p3.y, p4.y)) ||

                    (Math.Min(p1.y, p2.y) > Math.Max(p3.y, p4.y))))
                    {

                        return true;

                    }

                }

                return false;

            }

            //найдём коэффициенты уравнений, содержащих отрезки

            //f1(x) = A1*x + b1 = y

            //f2(x) = A2*x + b2 = y

            //если первый отрезок вертикальный

            if (p1.x - p2.x == 0)
            {

                //найдём Xa, Ya - точки пересечения двух прямых

                 Xa = p1.x;

                 A2 = (p3.y - p4.y) / (p3.x - p4.x);

                 b2 = p3.y - A2 * p3.x;

                 Ya = A2 * Xa + b2;

                if (p3.x <= Xa && p4.x >= Xa && Math.Min(p1.y, p2.y) <= Ya &&

                Math.Max(p1.y, p2.y) >= Ya)
                {

                    return true;

                }

                return false;

            }

            //если второй отрезок вертикальный

            if (p3.x - p4.x == 0)
            {

                //найдём Xa, Ya - точки пересечения двух прямых

                 Xa = p3.x;

                 A1 = (p1.y - p2.y) / (p1.x - p2.x);

                 b1 = p1.y - A1 * p1.x;

                 Ya = A1 * Xa + b1;

                if (p1.x <= Xa && p2.x >= Xa && Math.Min(p3.y, p4.y) <= Ya &&

                Math.Max(p3.y, p4.y) >= Ya)
                {

                    return true;

                }

                return false;

            }

            //оба отрезка невертикальные

             A1 = (p1.y - p2.y) / (p1.x - p2.x);

             A2 = (p3.y - p4.y) / (p3.x - p4.x);

             b1 = p1.y - A1 * p1.x;

             b2 = p3.y - A2 * p3.x;

            if (A1 == A2)
            {

                return false; //отрезки параллельны

            }

            //Xa - абсцисса точки пересечения двух прямых

            Xa = (b2 - b1) / (A1 - A2);

            if ((Xa < Math.Max(p1.x, p3.x)) || (Xa > Math.Min(p2.x, p4.x)))
            {

                return false; //точка Xa находится вне пересечения проекций отрезков на ось X

            }

            else
            {

                return true;

            }

        }
    }
    class Vertices
    {
        public Double x { get; set; }
        public Double y { get; set; }
        public Vertices(Double x, Double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
