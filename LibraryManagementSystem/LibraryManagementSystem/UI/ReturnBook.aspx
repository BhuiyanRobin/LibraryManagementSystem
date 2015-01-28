<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryManagementSystem.UI.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Member Number"></asp:Label>
        <asp:TextBox ID="memberNumberTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showBorrowButton" runat="server" OnClick="showBorrowButton_Click" Text="Show all borrow book" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Borrow book List"></asp:Label>
            <asp:DropDownList ID="bookListDropDownList" runat="server" Height="16px" Width="131px">
            </asp:DropDownList>
        </p>
        <asp:Button ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
    </form>
</body>
</html>
