using System;
using MatrixLibrary;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixA = new Matrix();

            Console.Write("Введите количество строк первой матрицы: ");
            int lines1 = Convert.ToInt32(Console.ReadLine());
            matrixA.Lines = lines1;
            Console.Write("Введите количество столбцов первой матрицы: ");
            int columns1 = Convert.ToInt32(Console.ReadLine());
            matrixA.Columns = columns1;

            matrixA.MatrixInput();
            matrixA.MatrixOutput();

            Matrix matrixB = new Matrix();

            Console.Write("Введите количество строк второй матрицы: ");
            int lines2 = Convert.ToInt32(Console.ReadLine());
            matrixB.Lines = lines2;
            Console.Write("Введите количество столбцов второй матрицы: ");
            int columns2 = Convert.ToInt32(Console.ReadLine());
            matrixB.Columns = columns2;

            matrixB.MatrixInput();
            matrixB.MatrixOutput();

            Matrix matrixC = new Matrix();

            Console.Write("Введите количество строк третьей матрицы: ");
            int lines3 = Convert.ToInt32(Console.ReadLine());
            matrixC.Lines = lines3;
            Console.Write("Введите количество столбцов третьей матрицы: ");
            int columns3 = Convert.ToInt32(Console.ReadLine());
            matrixC.Columns = columns3;

            matrixC.MatrixInput();
            matrixC.MatrixOutput();

            double sum1OfMatrixA = matrixA.SumOfSquares1(83.6);
            Console.WriteLine($"Сумма квадратов элементов матрицы matrixA, больших 83,6, равна {sum1OfMatrixA}");
            double sum1OfMatrixB = matrixB.SumOfSquares1(83.6);
            Console.WriteLine($"Сумма квадратов элементов матрицы matrixB, больших 83,6, равна {sum1OfMatrixB}");
            
            Console.Write("Введите координату i элемента, после которого необходимо посчитать сумму квадратов элеметов матрицы: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату j элемента, после которого необходимо посчитать сумму квадратов элеметов матрицы: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            double sum2OfMatrixC = matrixC.SumOfSquares2(number1, number2);
            Console.WriteLine($"Сумма квадратов элементов матрицы matrixC, находящихся после элемента " +
                $"matrixC[{number1}, {number2}], равна {sum2OfMatrixC}");

            Matrix matrixAB = matrixA * matrixB;
            double sum2OfMatrixAB = matrixAB.SumOfSquares2(number1, number2);
            Console.WriteLine($"Сумма квадратов элементов матрицы matrixAB, находящихся после элемента " +
                $"matrixAB[{number1}, {number2}], равна {sum2OfMatrixC}");

            if (matrixA == matrixB && matrixA == matrixC)
            {
                matrixA.ReplaceLastColumn();
                matrixA.MatrixOutput();
                matrixB.ReplaceLastColumn();
                matrixB.MatrixOutput();
                matrixC.ReplaceLastColumn();
                matrixC.MatrixOutput();
            }
            else
            {
                if (matrixB.Columns == matrixC.Lines)
                {
                    Matrix matrixBC = matrixB * matrixC;
                    matrixBC.MatrixOutput();
                }
            }
        }
    }
}