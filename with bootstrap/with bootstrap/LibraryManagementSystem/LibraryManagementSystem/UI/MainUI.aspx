<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="LibraryManagementSystem.UI.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Libray Management</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <div class=" padding container-fluid">
        <form id="form1" runat="server">
            <div>

                <asp:Button CssClass="customButton btn btn-group-sm" ID="borrowBooksButton" runat="server" Height="83px" OnClick="borrowBooksButton_Click" Text="Borrow Books" Width="132px" />
                <br />
                <br />

            </div>
            <asp:Button CssClass="customButton btn btn-group-sm" ID="returnBooksButton" runat="server" Height="93px" OnClick="returnBooksButton_Click" Text="Return Books" Width="132px" />
        </form>
    </div>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Scripts/custom.css" rel="stylesheet" />
</body>
</html>
