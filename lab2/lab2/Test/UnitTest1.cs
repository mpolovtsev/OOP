using lab2;
using VectorLibrary;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Vector vector1 = new Vector(1, 3, 4);
            Vector vector2 = new Vector(2, 1, 5);
            double result = vector1 * vector2;
            double expected = 25;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            Vector vector1 = new Vector(1, 3, 4);
            Vector vector2 = new Vector(2, 1, 5);
            Vector result = vector1 ^ vector2;
            Vector expected = new Vector(11, 3, -5);
            Assert.AreEqual(expected.x, result.x);
            Assert.AreEqual(expected.y, result.y);
            Assert.AreEqual(expected.z, result.z);
        }

        [TestMethod]
        public void Test3()
        {
            Vector vector = new Vector(1, 3, 4);
            double num = 5;
            Vector result = vector * num;
            Vector expected = new Vector(5, 15, 20);
            Assert.AreEqual(expected.x, result.x);
            Assert.AreEqual(expected.y, result.y);
            Assert.AreEqual(expected.z, result.z);
        }
    }
}