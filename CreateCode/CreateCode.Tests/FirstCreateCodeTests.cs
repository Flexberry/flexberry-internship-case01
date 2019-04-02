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
    public class FirstCreateCodeTests
    {
        [TestMethod()]
        public void FirstAlgCorrect()
        {
            //блок Arrange с тестовыми параметрами
            var Name = "Дом в поле";
            var Date = new DateTime(2016, 03, 20);
            var Account = "123456789";

            var ExpectedCode = "Домвпо200316456789";

            //Блок Act выполнения теста
            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

            //Блок Assert для сравнения ожидаемого результата с действительным
            Assert.AreEqual(ExpectedCode, Code);
        }
        [TestMethod()]
        public void FirstAlgCorrectShortAccount()
        {
            var Name = "Дом в поле";
            var Date = new DateTime(2016, 03, 20);
            var Account = "123";

            var ExpectedCode = "Домвпо200316000123";

            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

            Assert.AreEqual(ExpectedCode, Code);
        }

        [TestMethod()]
        public void FirstAlgCorrectShortName()
        {
            var Name = "Д о   м";
            var Date = new DateTime(2016, 03, 20);
            var Account = "123453";

            var ExpectedCode = "Дом200316123453";

            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

            Assert.AreEqual(ExpectedCode, Code);
        }
    }
}