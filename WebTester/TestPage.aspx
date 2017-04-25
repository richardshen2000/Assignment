<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="WebTester.TestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxDisplayer" runat="server" Width="351px"></asp:TextBox>
    
    </div>
        <asp:Button ID="btnWriteBack" runat="server" OnClick="btnWriteBack_Click" Text="Write back" Width="203px" />
    </form>
</body>
</html>
