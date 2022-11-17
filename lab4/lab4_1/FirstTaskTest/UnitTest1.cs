using lab4_1;

namespace FirstTaskTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Str str = new Str("��� ������ �������� 2 ����� \"������\".");
            string word = "������";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 2);
        }

        [TestMethod]
        public void Test2()
        {
            Str str = new Str("��� ������ �������� 2 ����� \"������\", �� ���� �� ��� - � ������� ��������.");
            string word = "������";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 1);
        }

        [TestMethod]
        public void Test3()
        {
            Str str = new Str("��� .������. �������� 2 ����� \"������\", �������������� � ���������� �� ������� ����������.");
            string word = "������";

            int amountOfOccurrence = str.FindOccurrence(word);
            Assert.AreEqual(amountOfOccurrence, 2);
        }
    }
}