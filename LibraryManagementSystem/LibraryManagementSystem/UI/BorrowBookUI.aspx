<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBookUI.aspx.cs" Inherits="LibraryManagementSystem.UI.BorrowBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Member Number"></asp:Label>
        <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="messageLable" runat="server"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Course List"></asp:Label>
        <asp:DropDownList ID="allBooksDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="allBooksDropDownList_SelectedIndexChanged" OnTextChanged="allBooksDropDownList_TextChanged" Width="124px">
        </asp:DropDownList>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
            <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
        </p>
    </form>
</body>
</html>
