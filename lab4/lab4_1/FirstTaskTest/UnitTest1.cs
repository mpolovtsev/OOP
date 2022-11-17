using lab4_1;

namespace FirstTaskTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Str str = new Str("Эта строка содержит 2 слова \"строка\".");
            string word = "строка";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 2);
        }

        [TestMethod]
        public void Test2()
        {
            Str str = new Str("Эта СТРОКА содержит 2 слова \"строка\", но одно из них - в верхнем регистре.");
            string word = "строка";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 1);
        }

        [TestMethod]
        public void Test3()
        {
            Str str = new Str("Эта .строка. содержит 2 слова \"строка\", использующиеся в комбинации со знаками пунктуации.");
            string word = "строка";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 2);
        }
    }
}