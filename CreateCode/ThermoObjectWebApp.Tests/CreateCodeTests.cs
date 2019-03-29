//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;
//using CreateCode;

//namespace ThermoObjectWebApp.Tests
//{
//    public class CreateCodeTests
//    {
//        [Fact]
//        public void FirstAlgCorrect()
//        {
//            //блок Arrange с тестовыми параметрами
//            var Name = "Дом в поле";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "123456789";

//            var ExpectedCode = "Домвпо200316456789";

//            //Блок Act выполнения теста
//            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

//            //Блок Assert для сравнения ожидаемого результата с действительным
//            Assert.Equal(ExpectedCode, Code);
//        }
//        [Fact]
//        public void FirstAlgCorrectShortAccount()
//        {
//            var Name = "Дом в поле";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "123";

//            var ExpectedCode = "Домвпо200316000123";

//            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

//            Assert.Equal(ExpectedCode, Code);
//        } 
//        [Fact]
//        public void FirstAlgCorrectShortName()
//        {
//            var Name = "Д о   м";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "123453";

//            var ExpectedCode = "Дом200316123453";

//            var Code = FirstCreateCode.GenerateCode(Name, Date, Account);

//            Assert.Equal(ExpectedCode, Code);
//        }
//        [Fact]
//        public void SecondAlgCorrectAll()
//        {
//            var Name = "Труба в поле";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "1234567";

//            var ExpectedCode = "200316Трубавпо4567";

//            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);

//            Assert.Equal(ExpectedCode, Code);
//        }
//        [Fact]
//        public void SecondAlgCorrectShortAccount()
//        {
//            var Name = "Труба в поле";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "1";

//            var ExpectedCode = "200316Трубавпо0001";

//            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);

//            Assert.Equal(ExpectedCode, Code);
//        }
//        [Fact]
//        public void SecondAlgCorrectShortName()
//        {
//            var Name = "Тр у б     а";
//            var Date = new DateTime(2016, 03, 20);
//            var Account = "1";

//            var ExpectedCode = "200316Труба0001";

//            var Code = SecondCreateCode.GenerateCode(Name, Date, Account);

//            Assert.Equal(ExpectedCode, Code);
//        }
//    }
//}
