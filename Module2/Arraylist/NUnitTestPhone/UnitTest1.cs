using NUnit.Framework;
using PhoneList;

namespace NUnitTestPhone
{
    public class Tests
    {
        public PhoneBook result;
        [SetUp]
        public void Setup()
        {
            result = new PhoneBook();
        }


        [Test]
        public void Test_InsertPhone()
        {
            result.InserPhone("Khoa", "123");
            Assert.IsTrue(result.PhoneList.Count ==4);
        }
    }
}