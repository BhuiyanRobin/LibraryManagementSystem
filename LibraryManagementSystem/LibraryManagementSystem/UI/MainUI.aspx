<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="LibraryManagementSystem.UI.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="borrowBooksButton" runat="server" Height="83px" OnClick="borrowBooksButton_Click" Text="Borrow Books" Width="132px" />
        <br />
    
    </div>
        <asp:Button ID="returnBooksButton" runat="server" Height="93px" OnClick="returnBooksButton_Click" Text="Return Books" Width="132px" />
    </form>
</body>
</html>
