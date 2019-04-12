using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThermoObject;
using CreateCode;

namespace ThermoObjectWebApp
{
    public partial class GenerateCodeUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetCodeButton_Click(object sender, EventArgs e)
        { //Элементы с постфиксом ...Warning - для оповещения пользователя о некорректном вводе
            GeneratedCode.Text = ""; //Устанавливаем значения элементов формы по умолчанию
            NameWarning.Visible = false;
            DateWarning.Visible = false;
            AccountWarning.Visible = false;
            GeneratedCodeLabel.Visible = false;
            GeneratedCode.Visible = false;
            GeneratedCodeLabel2.Visible = false;
            GeneratedCode2.Visible = false;
            bool IsInputErrors = false; //Флаг ошибок ввода (True, если ошибки есть)
            int temp = 0; //Переменная для хранения номера лицевого счёта
            if (DateTextBox.Text == "" || DateTime.Today.CompareTo(Convert.ToDateTime(DateTextBox.Text)) == -1)
                DateWarning.Visible = true; //Выводим пользователю сообщение о некорректном заполнении поля
            if (NameTextBox.Text == "")
                NameWarning.Visible = true;
            if (AccountTextBox.Text == "" || AccountTextBox.Text[0] == '-' || !Int32.TryParse(AccountTextBox.Text, out temp))
                AccountWarning.Visible = true;
            if (NameWarning.Visible || DateWarning.Visible || AccountWarning.Visible)
                IsInputErrors = true; //Если есть хоть одна ошибка - переводим флаг в true
            string Account = temp.ToString().Replace(" ", "");
            if (!IsInputErrors) //если ошибок не возникло
            {
                DateTime InputDate = Convert.ToDateTime(DateTextBox.Text);
                GeneratedCode.Text = FirstCreateCode.GenerateCode(NameTextBox.Text, InputDate, Account).Replace(" ","");
                GeneratedCode2.Text = SecondCreateCode.GenerateCode(NameTextBox.Text, InputDate, Account).Replace(" ","");
                GeneratedCodeLabel.Visible = true; // Показываем результат пользователю
                GeneratedCode.Visible = true;
                GeneratedCodeLabel2.Visible = true;
                GeneratedCode2.Visible = true;
                NameWarning.Visible = false;    // Убираем все сообщения об ошибках 
                DateWarning.Visible = false;
                AccountWarning.Visible = false;
            }
        }
    }
}