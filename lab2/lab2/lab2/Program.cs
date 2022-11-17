using System;
using VectorLibrary;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первого вектора");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Vector vector1 = new Vector(x1, y1, z1);

            Console.WriteLine("Введите координаты второго вектора");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            Vector vector2 = new Vector(x2, y2, z2);

            Console.WriteLine($"\nVector1 = ({x1}, {y1}, {z1})");
            Console.WriteLine($"\nVector2 = ({x2}, {y2}, {z2})");

            double productOfVectors = vector1 * vector2;
            Console.WriteLine($"\nСкалярное произведение векторов равно {productOfVectors}");

            Vector vector3 = vector1 ^ vector2;
            Console.WriteLine($"\nВекторное произведение векторов равно vector = ({vector3.x}, {vector3.y}, {vector3.z})");

            Console.WriteLine("\nВведите число для умножения на вектор");
            double num = Convert.ToDouble(Console.ReadLine());
            Vector vector4 = vector1 * num;
            Console.WriteLine($"\nПроизведение вектора vector = ({vector1.x}, {vector1.y}, {vector1.z}) " +
                $"на число {num} равно vector = ({vector4.x}, {vector4.y}, {vector4.z})");
        }
    }
}