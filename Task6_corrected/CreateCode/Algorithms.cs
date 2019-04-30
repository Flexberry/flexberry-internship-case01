using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateCode
{
    //Первый алгоритм генерации цифро-буквенного кода
    //Входные данные: Наименование объекта (Name), Дата (Date), Лицевой счёт (Account)
    //Код составляется из 3 частей:
    // 1 часть : 6 первых символов наименования объекта (без пробелов)
    // 2 часть : дата в формате ДДММГГ. Например: 080319
    // 3 часть : последние 6 символов лицевого счёта
    // В случае, если лицевой счёт состоит из менее, чем 6 символов,
    // 3 часть дополняется ведущими нулями
    // При этом длина итогового цифро-буквенного кода не превышает 18 символов
    public class FirstCreateCode
    {
        public static string GenerateCode(string Name, DateTime Date, int Account)
        {
            string temp_Name;
            string temp_Account;
            temp_Name = Name.Replace(" ", ""); //Удаляем пробелы в названии
            if (temp_Name.Length > 6)
                temp_Name = temp_Name.Substring(0, 6); //Сохраняем первые 6 символов названия
            temp_Account = Convert.ToString(Account);
            if (temp_Account.Length > 6)
                temp_Account = temp_Account.Substring(temp_Account.Length - 6, 6); //Сохраняем последние 6 символов лицевого счёта
            else
                temp_Account = FillWithZero(temp_Account);
            string Code = temp_Name + Date.Day.ToString("00") + Date.Month.ToString("00") + Date.Year.ToString().Substring(2,2) + temp_Account;
            return Code;
        }
        //Метод дополняет входную строку до 6 символов ведущими нулями 
        private static string FillWithZero(string str)
        {
            int CountOfZeros = 6 - str.Length;
            for (int i = 0; i < CountOfZeros; i++)
                str = "0" + str;
            return str;
        }
    }
    //Второй алгоритм генерации цифро-буквенного кода
    //Входные данные: Наименование объекта (Name), Дата (Date), Лицевой счёт (Account)
    //Код составляется из 3 частей:
    // 1 часть : дата в формате ДДММГГ. Например: 080319 - Восьмое марта 2019 года
    // 2 часть : 8 первых символов наименования объекта (без пробелов)
    // 3 часть : последние 4 символа лицевого счёта
    // В случае, если лицевой счёт состоит из менее, чем 4 символов,
    // 3 часть дополняется ведущими нулями
    // при этом длина итогового цифро-буквенного кода не превышает 18 символов
    // Выбор этого алгоритма обсуловлен дальнейшей возможностью удобной сортировки
    // цифро-буквенных кодов по дате регистрации объектов
    public class SecondCreateCode
    {
        public static string GenerateCode(string Name, DateTime Date, string Account)
        {
            string temp_Name; //Переменная для хранения 2 части
            string temp_Account; //Переменная для хранения 3 части
            temp_Name = Name.Replace(" ", "");
            if (temp_Name.Length > 8)
                temp_Name = temp_Name.Substring(0,8);
            if (Account.Length > 4)
                temp_Account = Account.Substring(Account.Length - 4, 4);
            else
                temp_Account = FillWithZero(Account); //Дополняем строку ведущими символами '0'
            string Code = Date.Day.ToString("00") + Date.Month.ToString("00") + Date.Year.ToString().Substring(2, 2) + temp_Name + temp_Account;
            return Code;
        }
        //Дополняем входную строку символами '0'
        private static string FillWithZero(string str)
        {
            int CountOfZeros = 4 - str.Length;
            for (int i = 0; i < CountOfZeros; i++)
                str = "0" + str;
            return str;
        }
    }
}
