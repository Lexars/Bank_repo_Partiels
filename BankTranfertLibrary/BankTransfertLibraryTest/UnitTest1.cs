using BankTranfertLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTransfertLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTransfert()
        {
            var bankTransfert = new Stream();
            bankTransfert.StreamWriter(1, 12.2m, "4514561", "8546129856", "c:/");
            
           
        }

        [TestMethod]
        public void TestIban()
        {
            var bankTransfert = new BankTransfert();
            bool result =bankTransfert.EmulateTransfert(1, "252652", "252653");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLog()
        {
            var log = new Stream();
            log.StreamWriter("log", "c:/");
        }


    }
}
