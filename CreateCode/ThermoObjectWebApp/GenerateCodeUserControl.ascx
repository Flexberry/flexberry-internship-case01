<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerateCodeUserControl.ascx.cs" Inherits="ThermoObjectWebApp.GenerateCodeUserControl" %>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Для получения цифро-буквенного кода введите информацию об объекте теплопотребления (все поля должны быть заполнены):"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Наименование объекта:"></asp:Label>
        <br />
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="NameWarning" runat="server" Font-Size="10pt" ForeColor="Red" Text="*Поле необходимо заполнить" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Дата регистрации:"></asp:Label>
        <br />
        <asp:TextBox ID="DateTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="DateWarning" runat="server" Font-Size="10pt" ForeColor="Red" Text="*Поле заполнено некорректно" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Лицевой счёт потребителя:"></asp:Label>
        <br />
        <asp:TextBox ID="AccountTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="AccountWarning" runat="server" Font-Size="10pt" ForeColor="Red" Text="*Поле заполнено некорректно" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="GetCodeButton" runat="server" OnClick="GetCodeButton_Click" Text="Получить код" Width="200px" />
        <br />
        <br />
        <asp:Label ID="GeneratedCodeLabel" runat="server" Text="Цифро-буквенный код (алгоритм 1): " Visible="False"></asp:Label>
        <asp:Label ID="GeneratedCode" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="GeneratedCodeLabel2" runat="server" Text="Цифро-буквенный код (алгоритм 2):" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="GeneratedCode2" runat="server" Visible="False"></asp:Label>