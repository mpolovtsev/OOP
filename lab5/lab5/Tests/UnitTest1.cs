using lab5;
using System.Text.RegularExpressions;
using PhoneNumberLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {  
            string[] arrayOfNum = new string[6] {"+375 (29) 144-23-59", "8-029-312-66-15",
                "+375 (29) 723-23-01", "+375 (44) 521-04-18", "7", "8-023-310-91-25"};
            string stringOfNum = String.Join(" ", arrayOfNum);

            Regex mobilePhonePattern = new Regex(@"\+375\s\(\d{2}\)\s\d{3}-\d{2}-\d{2}");
            MatchCollection result = PhoneNumber.NumberSearch(ref stringOfNum, mobilePhonePattern);
            string[] expected = new string[3] {"+375 (29) 144-23-59", "+375 (29) 723-23-01", "+375 (44) 521-04-18"};

            Assert.AreEqual(expected[0], result[0].Value);
            Assert.AreEqual(expected[1], result[1].Value);
            Assert.AreEqual(expected[2], result[2].Value);
        }

        [TestMethod]
        public void Test2()
        {
            string[] arrayOfNum = new string[6] {"+375 (29) 144-23-59", "8-029-312-66-15",
                "+375 (29) 723-23-01", "+375 (44) 521-04-18", "7", "8-023-310-91-25"};
            string stringOfNum = String.Join(" ", arrayOfNum);

            Regex cityPhonePattern = new Regex(@"8-\d{2,4}-\d{3}-\d{2}-\d{2}");
            MatchCollection result = PhoneNumber.NumberSearch(ref stringOfNum, cityPhonePattern);
            string[] expected = new string[2] {"8-029-312-66-15", "8-023-310-91-25"};

            Assert.AreEqual(expected[0], result[0].Value);
            Assert.AreEqual(expected[1], result[1].Value);
        }

        [TestMethod]
        public void Test3()
        {
            string stringOfNum = "5  7    12 ";

            Regex incorrectValPattern = new Regex(@"\w+");
            MatchCollection result = PhoneNumber.NumberSearch(ref stringOfNum, incorrectValPattern);
            string[] expected = new string[3] {"5", "7", "12"};

            Assert.AreEqual(expected[0], result[0].Value);
            Assert.AreEqual(expected[1], result[1].Value);
            Assert.AreEqual(expected[2], result[2].Value);
        }

        [TestMethod]
        public void Test4()
        {
            string[] arrayOfNum = new string[6] {"+375 (29) 144-23-59", "8-029-312-66-15",
                "+375 (29) 723-23-01", "+375 (44) 521-04-18", "7", "8-023-310-91-25"};
            string stringOfNum = String.Join(" ", arrayOfNum);

            Regex mobilePhonePattern = new Regex(@"\+375\s\(\d{2}\)\s\d{3}-\d{2}-\d{2}");
            MatchCollection collectionOfNum = PhoneNumber.NumberSearch(ref stringOfNum, mobilePhonePattern);
            string[] result = PhoneNumber.Conversion(collectionOfNum);
            string[] expected = new string[3] {"+375 (29) 144-23-59", "+375 (29) 723-23-01", "+375 (44) 521-04-18"};

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
        }
    }
}