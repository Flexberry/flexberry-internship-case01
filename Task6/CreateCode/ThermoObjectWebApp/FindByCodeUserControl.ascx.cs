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
    public partial class FindByCodeUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetInfoButton_Click(object sender, EventArgs e)
        {
            //Устанавливаем начальные параметры компонентов (скрываем ненужные)
            InfoNameLabel.Visible = false;
            InfoDateLabel.Visible = false;
            InfoAccountLabel.Visible = false;
            InfoName.Visible = false;
            InfoDate.Visible = false;
            InfoAccount.Visible = false;
            CodeWarning.Visible = false;
            try
            {
                //Пытаемся найти в списке объектов нужный по коду
                ThermoObjectC obj = Find.FindByCode(CodeTextBox.Text.Replace(" ",""));
                InfoNameLabel.Visible = true;
                InfoDateLabel.Visible = true;
                InfoAccountLabel.Visible = true;
                InfoName.Visible = true;
                InfoDate.Visible = true;
                InfoAccount.Visible = true;
                InfoName.Text = obj.Name;
                InfoDate.Text = obj.Date.ToString();
                InfoAccount.Text = obj.Account;
            }
            catch (KeyNotFoundException ex)
            {
                CodeWarning.Visible = true;
            }
        }
    }
}