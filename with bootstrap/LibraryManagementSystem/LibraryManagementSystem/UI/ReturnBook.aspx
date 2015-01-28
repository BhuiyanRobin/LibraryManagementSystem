<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryManagementSystem.UI.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Return Books</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <div class="padding container">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Member Number"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="memberNumberTextBox" runat="server" Width="300"></asp:TextBox>
                <br />
            </div>
&nbsp;<asp:Button CssClass="customButton btn" ID="showBorrowButton" runat="server" OnClick="showBorrowButton_Click" Text="Show all borrow book" />
            <p>
                <asp:Label ID="Label2" runat="server" Text="Borrow book List"></asp:Label>
                <asp:DropDownList CssClass="form-control" ID="bookListDropDownList" runat="server" Width="300">
                </asp:DropDownList>
            </p>
            <asp:Button CssClass="customButton btn" ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
        </form>
    </div>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Scripts/custom.css" rel="stylesheet" />
</body>
</html>
