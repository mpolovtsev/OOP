using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;

namespace MatrixLibrary
{
    public class Matrix
    {
        double[,] matrix;

        public Matrix()
        {
            this.matrix = new double[5, 5];
        }

        public Matrix(int amountOfLines, int amountOfColumns)
        {
            this.matrix = new double[amountOfLines, amountOfColumns];
        }

        int amountOfLines;
        int amountOfColumns;

        public int Lines
        {
            get { return amountOfLines; }
            set { amountOfLines = value; }
        }

        public int Columns
        {
            get { return amountOfColumns; }
            set { amountOfColumns = value; }
        }

        public double this[int i, int j]
        {
            get
            {
                if ((i >= 0) && (i < amountOfLines) && (j >= 0) && (j < amountOfColumns))
                {
                    return matrix[i, j];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if ((i >= 0) && (i < amountOfLines) && (j >= 0) && (j < amountOfColumns))
                {
                    matrix[i, j] = value;
                }
            }
        }

        public void MatrixInput()
        {
            for (int i = 0; i < amountOfLines; i++)
            {
                for (int j = 0; j < amountOfColumns; j++)
                {
                    Console.Write($"Введите элемент матрицы matrix[{i}, {j}]: ");
                    this.matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public void MatrixOutput()
        {
            for (int i = 0; i < amountOfLines; i++)
            {
                for (int j = 0; j < amountOfColumns; j++)
                {
                    Console.Write($"  {matrix[i, j]}  ");
                }
                Console.WriteLine("\n");
            }
        }

        public double SumOfSquares1(int border)
        {
            double sum = 0;

            for (int i = 0; i < amountOfLines; i++)
            {
                for (int j = 0; j < amountOfColumns; j++)
                {
                    if (matrix[i, j] > border)
                    {
                        sum += matrix[i, j] * matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public double SumOfSquares1(double border)
        {
            double sum = 0;

            for (int i = 0; i < amountOfLines; i++)
            {
                for (int j = 0; j < amountOfColumns; j++)
                {
                    if (matrix[i, j] > border)
                    {
                        sum += matrix[i, j] * matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public double SumOfSquares2(int line, int column)
        {
            double sum;
            if (line == amountOfLines - 1 && column == amountOfColumns - 1)
            {
                sum = 0;
            }
            else
            {
                if (line < amountOfLines - 1 && column == amountOfColumns - 1)
                {
                    line++;
                    column = 0;
                }
                else
                {
                    column++;
                }

                double[] array = new double[amountOfLines * amountOfColumns];
                int k = 0;

                for (int i = 0; i < amountOfLines; i++)
                {
                    for (int j = 0; j < amountOfColumns; j++)
                    {
                        array[k] = matrix[i, j];
                        k++;
                    }
                }

                column = line * amountOfLines + column;
                sum = 0;
                for (int i = amountOfLines * amountOfColumns - 1; i >= column; i--)
                {
                    sum += array[i] * array[i];
                }
            }
            return sum;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix3 = new Matrix();
            matrix3.Lines = matrix1.Lines;
            matrix3.Columns = matrix2.Columns;
            for (int i = 0; i < matrix1.Lines; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return matrix3;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            bool isEqual = true;

            if (matrix1.Lines == matrix2.Lines && matrix1.Columns == matrix2.Columns)
            {
                for (int i = 0; i < matrix1.Lines && isEqual; i++)
                {
                    for (int j = 0; j < matrix1.Columns && isEqual; j++)
                    {
                        if (matrix1[i, j] != matrix2[i, j])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            else
            {
                isEqual = false;
            }

            return isEqual;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            bool isNotEqual = false;

            if (matrix1.Lines == matrix2.Lines && matrix1.Columns == matrix2.Columns)
            {
                for (int i = 0; i < matrix1.Lines && !isNotEqual; i++)
                {
                    for (int j = 0; j < matrix1.Columns && !isNotEqual; j++)
                    {
                        if (matrix1[i, j] != matrix2[i, j])
                        {
                            isNotEqual = true;
                        }
                    }
                }
            }
            else
            {
                isNotEqual = true;
            }

            return isNotEqual;
        }
        public void ReplaceLastColumn()
        {
            for (int i = 0, j = amountOfColumns - 1; i < amountOfLines; i++)
            {
                if (matrix[i, j] < 0)
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }
}