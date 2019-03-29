using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCode.Tests
{
    [TestClass()]
    public class SecondCreateCodeTests
    {
        //[TestMethod()]
        //public void GenerateCodeTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void SecondAlgCorrectAll()
        {
            var Name = "Труба в поле";
            var Date = new DateTime(2016, 03, 20);
            var Account = "1234567";

            var ExpectedCode = "200316Трубавпо4567";

            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);
            
            Assert.AreEqual(ExpectedCode, Code);
        }
        [TestMethod()]
        public void SecondAlgCorrectShortAccount()
        {
            var Name = "Труба в поле";
            var Date = new DateTime(2016, 03, 20);
            var Account = "1";

            var ExpectedCode = "200316Трубавпо0001";

            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);

            Assert.AreEqual(ExpectedCode, Code);
        }
        [TestMethod()]
        public void SecondAlgCorrectShortName()
        {
            var Name = "Тр у б     а";
            var Date = new DateTime(2016, 03, 20);
            var Account = "1";

            var ExpectedCode = "200316Труба0001";

            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);

            Assert.AreEqual(ExpectedCode, Code);
        }
    }
}