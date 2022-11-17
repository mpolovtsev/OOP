using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace SquareLibrary
{
    public class Square
    {
        public double[,] points;

        public Square(double[,] points)
        {
            this.points = new double[points.GetLength(0), points.GetLength(1)];
            Array.Copy(points, this.points, points.Length);
        }

        public void Print()
        {
            Console.WriteLine("Кординаты вершин квадрата:");
            for (int i = 0; i < points.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    Console.Write($"{points[i, j]} ");
                }
                Console.Write("]\n");
            }
        }

        public bool CheckExistence(Vector2 vector1, Vector2 vector2, Vector2 vector3, Vector2 vector4)
        {
            double angle1 = Math.Acos(Vector2.Dot(vector1, vector3) / (vector1.Length() * vector2.Length()));
            double angle2 = Math.Acos(Vector2.Dot(vector2, vector4) / (vector2.Length() * vector4.Length()));

            bool checkParallelism = Math.Abs(angle1 - Math.PI) < 0.000001 && Math.Abs(angle2 - Math.PI) < 0.000001;
            bool checkEquality = (Math.Abs(vector1.Length() - vector2.Length()) < 0.000001) &&
                ((Math.Abs(vector3.Length() - vector4.Length())) < 0.000001) &&
                ((Math.Abs(vector1.Length() - vector4.Length())) < 0.000001);
            return checkParallelism && checkEquality;
        }

        public float SideLength(Vector2 vector)
        {
            return vector.Length();
        }

        public double Area(double sideLength)
        {
            return sideLength * sideLength;
        }

        public double Perimeter(double sideLength)
        {
            return 4 * sideLength;
        }

        public bool CheckBelonging(double x, double y, double[,] points)
        {
            return ((x >= points[0, 0]) && (x <= points[3, 0]) && (y >= points[0, 1]) && (y <= points[1, 1]));
        }
    }
}