using System;
using System.Numerics;
using SquareLibrary;

namespace lab1
{
    class Program
    { 
        static void Main(string[] args)
        {
            double[,] points = new double[4, 2];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите координату x{i + 1}: ");
                points[i, 0] = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Введите координату y{i + 1}: ");
                points[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            Square square = new Square(points);
            square.Print();

            Vector2 vector1 = new Vector2((float)(points[1, 0] - points[0, 0]), (float)(points[1, 1] - points[0, 1]));
            Vector2 vector2 = new Vector2((float)(points[2, 0] - points[1, 0]), (float)(points[2, 1] - points[1, 1]));
            Vector2 vector3 = new Vector2((float)(points[3, 0] - points[2, 0]), (float)(points[3, 1] - points[2, 1]));
            Vector2 vector4 = new Vector2((float)(points[0, 0] - points[3, 0]), (float)(points[0, 1] - points[3, 1]));

            if (square.CheckExistence(vector1, vector2, vector3, vector4))
            {

                Console.WriteLine("Фигура существует");

                double sideLength = square.SideLength(vector1);
                Console.WriteLine($"\nДлина стороны квадрата равна {sideLength}");

                double area = square.Area(sideLength);
                Console.WriteLine($"\nПлощадь квадрата равна {area}");

                double perimeter = square.Perimeter(sideLength);
                Console.WriteLine($"\nПериметр квадрата равен {perimeter}\n");

                Console.WriteLine("Введите координату x точки:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату y точки:");
                double y = Convert.ToDouble(Console.ReadLine());
                if (square.CheckBelonging(x, y, points))
                {
                    Console.WriteLine($"Точка [{x} , {y}] принадлежит данной фигуре");
                }
                else
                {
                    Console.WriteLine($"Точка [{x} , {y}] не принадлежит данной фигуре");
                }
            }
            else
            {
                Console.WriteLine($"Фигура не существует");
            }
        }
    }
}

