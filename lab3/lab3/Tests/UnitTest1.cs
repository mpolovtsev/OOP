using System.Numerics;
using lab3;
using MatrixLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Matrix matrix = new Matrix();
            matrix.Lines = 2;
            matrix.Columns = 2;
            matrix[0, 0] = 1;
            matrix[0, 1] = 85;
            matrix[1, 0] = 9;
            matrix[1, 1] = 4;
            double result = matrix.SumOfSquares1(83.6);
            double expected = 7225;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            Matrix matrix = new Matrix();
            matrix.Lines = 2;
            matrix.Columns = 2;
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4.5;
            double result = matrix.SumOfSquares2(0, 0);
            double expected = 33.25;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3()
        {
            Matrix matrixA = new Matrix();
            matrixA.Lines = 2;
            matrixA.Columns = 2;
            matrixA[0, 0] = 1;
            matrixA[0, 1] = 2;
            matrixA[1, 0] = 3;
            matrixA[1, 1] = 4;

            Matrix matrixB = new Matrix();
            matrixB.Lines = 2;
            matrixB.Columns = 2;
            matrixB[0, 0] = 5;
            matrixB[0, 1] = 6;
            matrixB[1, 0] = 7;
            matrixB[1, 1] = 8;

            Matrix expected = new Matrix();
            expected.Lines = 2;
            expected.Columns = 2;
            expected[0, 0] = 19;
            expected[0, 1] =22;
            expected[1, 0] = 43;
            expected[1, 1] = 50;

            Matrix result = matrixA * matrixB;

            Assert.AreEqual(result[0, 0], expected[0, 0]);
            Assert.AreEqual(result[0, 1], expected[0, 1]);
            Assert.AreEqual(result[1, 0], expected[1, 0]);
            Assert.AreEqual(result[1, 1], expected[1, 1]);
        }

        [TestMethod]
        public void Test4()
        {
            Matrix matrixA = new Matrix();
            matrixA.Lines = 2;
            matrixA.Columns = 2;
            matrixA[0, 0] = 1;
            matrixA[0, 1] = 2;
            matrixA[1, 0] = 3;
            matrixA[1, 1] = 4;

            Matrix matrixB = new Matrix();
            matrixB.Lines = 2;
            matrixB.Columns = 2;
            matrixB[0, 0] = 1;
            matrixB[0, 1] = 2;
            matrixB[1, 0] = 3;
            matrixB[1, 1] = 4;

            bool result = matrixA == matrixB;
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Test5()
        {
            Matrix matrix = new Matrix();
            matrix.Lines = 2;
            matrix.Columns = 2;
            matrix[0, 0] = 1;
            matrix[0, 1] = -2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            Matrix expected = new Matrix();
            expected.Lines = 2;
            expected.Columns = 2;
            expected[0, 0] = 1;
            expected[0, 1] = 0;
            expected[1, 0] = 3;
            expected[1, 1] = 4;

            matrix.ReplaceLastColumn();

            Assert.AreEqual(matrix[0, 0], expected[0, 0]);
            Assert.AreEqual(matrix[0, 1], expected[0, 1]);
            Assert.AreEqual(matrix[1, 0], expected[1, 0]);
            Assert.AreEqual(matrix[1, 1], expected[1, 1]);
        }
    }
}