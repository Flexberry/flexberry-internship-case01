<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FindByCodeUserControl.ascx.cs" Inherits="ThermoObjectWebApp.FindByCodeUserControl" %>
        <asp:Label ID="HeadLabel" runat="server" Text="Для получения информации об объекте теплопотребления введите цифро-буквенный код"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Код (максимум 18 символов):"></asp:Label>
&nbsp;<asp:TextBox ID="CodeTextBox" runat="server" MaxLength="18" Width="200px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CodeWarning" runat="server" Font-Size="10pt" ForeColor="Red" Text="*Поле заполнено некорректно" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="GetInfoButton" runat="server" OnClick="GetInfoButton_Click" Text="Получить информацию" />
        <br />
        <br />
        <asp:Label ID="InfoNameLabel" runat="server" Text="Имя: " Visible="False"></asp:Label>
        <asp:Label ID="InfoName" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="InfoDateLabel" runat="server" Text="Дата:" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="InfoDate" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="InfoAccountLabel" runat="server" Text="Номер лицевого счёта:" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="InfoAccount" runat="server" Visible="False"></asp:Label>