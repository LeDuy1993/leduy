using System;
using Xunit;
using PhoneList;

namespace XUnitTestProject1
{
    public class XUnitTest
    {

        private PhoneBook phoneBook;
        public XUnitTest()
        {
            phoneBook = new PhoneBook();
        }
        [Fact]
        public void Test1()
        {
            Assert.True(phoneBook.CheckName("Duy", ));
        }
    }
}
