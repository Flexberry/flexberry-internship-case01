using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreateCode;
using ThermoObject;

namespace ThermoObjectWebApp
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void GetInfoButton_Click(object sender, EventArgs e)
        //{
        //    //Устанавливаем начальные параметры компонентов (скрываем ненужные)
        //    InfoNameLabel.Visible = false;
        //    InfoDateLabel.Visible = false;
        //    InfoAccountLabel.Visible = false;
        //    InfoName.Visible = false;
        //    InfoDate.Visible = false;
        //    InfoAccount.Visible = false;
        //    CodeWarning.Visible = false;
        //    try
        //    {
        //        //Пытаемся найти в списке объектов нужный по коду
        //        ThermoObjectC obj = Find.FindByCode(CodeTextBox.Text);
        //        InfoNameLabel.Visible = true;
        //        InfoDateLabel.Visible = true;
        //        InfoAccountLabel.Visible = true;
        //        InfoName.Visible = true;
        //        InfoDate.Visible = true;
        //        InfoAccount.Visible = true;
        //        InfoName.Text = obj.Name;
        //        InfoDate.Text = obj.Date.ToString();
        //        InfoAccount.Text = obj.Account;
        //    }
        //    catch (KeyNotFoundException ex)
        //    {
        //        CodeWarning.Visible = true;
        //    }
        //}

        //protected void GetCodeButton_Click(object sender, EventArgs e)
        //{ //Элементы с постфиксом ...Warning - для оповещения пользователя о некорректном вводе
        //    GeneratedCode.Text = ""; //Устанавливаем значения элементов формы по умолчанию
        //    NameWarning.Visible = false; 
        //    DateWarning.Visible = false;
        //    AccountWarning.Visible = false;
        //    GeneratedCodeLabel.Visible = false;
        //    GeneratedCode.Visible = false;
        //    GeneratedCodeLabel2.Visible = false;
        //    GeneratedCode2.Visible = false;
        //    bool IsInputErrors = false; //Флаг ошибок ввода (True, если ошибки есть)
        //    int temp=0; //Переменная для хранения номера лицевого счёта
        //    if (DateTextBox.Text == "" || DateTime.Today.CompareTo(Convert.ToDateTime(DateTextBox.Text)) == -1)
        //        DateWarning.Visible = true; //Выводим пользователю сообщение о некорректном заполнении поля
        //    if (NameTextBox.Text == "")
        //        NameWarning.Visible = true;
        //    if (AccountTextBox.Text == "" || AccountTextBox.Text[0]=='-' || !Int32.TryParse(AccountTextBox.Text, out temp))
        //        AccountWarning.Visible = true;
        //    if (NameWarning.Visible || DateWarning.Visible || AccountWarning.Visible)
        //        IsInputErrors = true; //Если есть хоть одна ошибка - переводим флаг в true
        //    string Account = temp.ToString().Replace(" ", "");
        //    if (!IsInputErrors) //если ошибок не возникло
        //    {
        //        DateTime InputDate = Convert.ToDateTime(DateTextBox.Text);
        //        GeneratedCode.Text = FirstCreateCode.GenerateCode(NameTextBox.Text, InputDate, Account);
        //        GeneratedCode2.Text = SecondCreateCode.GenerateCode(NameTextBox.Text, InputDate, Account);
        //        GeneratedCodeLabel.Visible = true; // Показываем результат пользователю
        //        GeneratedCode.Visible = true;
        //        GeneratedCodeLabel2.Visible = true;
        //        GeneratedCode2.Visible = true;
        //        NameWarning.Visible = false;    // Убираем все сообщения об ошибках 
        //        DateWarning.Visible = false;    
        //        AccountWarning.Visible = false; 
        //    }
        //}
    }
}