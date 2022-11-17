using System.Text;
using System.Text.RegularExpressions;
using lab4_2;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            StringBuilder str = new StringBuilder("���� ����� �� �������. This text in English. ���� ����� ����� �� �������.");
            string pattern = @"[�-��-�]+[\.\,\;\:\?\!]*";
            string[] result = Str.FormationNewText(str, pattern);
            string[] expected = new string[] {"����", "�����", "��", "�������.", "����", "�����", "�����", "��", "�������." };

            bool isEquals = true;

            for (int i = 0; i < result.Length && isEquals; i++)
            {
                if (result[i] != expected[i])
                    isEquals = false;
            }

            Assert.AreEqual(isEquals, true);
        }

        [TestMethod]
        public void Test2()
        {
            StringBuilder str = new StringBuilder("This text in English.");
            string pattern = @"[�-��-�]+[\.\,\;\:\?\!]*";
            string[] result = Str.FormationNewText(str, pattern);

            bool isEquals = false;

            if (result.Length == 0)
            { 
                isEquals = true;
            }

            Assert.AreEqual(isEquals, true);
        }
    }
}