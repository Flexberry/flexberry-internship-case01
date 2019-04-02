<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="ThermoObjectWebApp.MainForm" %>

<%@ Register src="FindByCodeUserControl.ascx" tagname="FindByCodeUserControl" tagprefix="uc1" %>

<%@ Register src="GenerateCodeUserControl.ascx" tagname="GenerateCodeUserControl" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:FindByCodeUserControl ID="FindByCodeUserControl1" runat="server" />
        <uc2:GenerateCodeUserControl ID="GenerateCodeUserControl1" runat="server" />
    </div>
    </form>
</body>
</html>
