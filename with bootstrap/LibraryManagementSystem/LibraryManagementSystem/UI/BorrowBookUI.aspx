<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBookUI.aspx.cs" Inherits="LibraryManagementSystem.UI.BorrowBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Borrow Books</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <div class="padding container">


        <form id="form1" runat="server">
            <div>

                <asp:Label ID="Label1" runat="server" Text="Member Number"></asp:Label>
                <asp:TextBox CssClass="form-control col-lg-3" ID="memberNoTextBox" runat="server" Width="300"></asp:TextBox>
                <asp:Label ID="messageLable" runat="server"></asp:Label>
                <div class="modal fade modal-sm" id="messageModal" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
                    <div class="modal-dialog modal-sm">
                        <div class="modal-content">
                            ...
                        </div>
                    </div>
                </div>
                <br />

            </div>
            <asp:Label ID="Label2" runat="server" Text="Course List"></asp:Label>
            <asp:DropDownList CssClass="form-control" ID="allBooksDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="allBooksDropDownList_SelectedIndexChanged" OnTextChanged="allBooksDropDownList_TextChanged" Width="300">
            </asp:DropDownList>
            <asp:Label ID="messageLabel" runat="server"></asp:Label>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="authorTextBox" runat="server" Width="300"></asp:TextBox>
            </p>
            <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="publisherTextBox" runat="server" Width="300"></asp:TextBox>
            <p>
                <asp:Button CssClass="customButton btn" ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
            </p>
        </form>
    </div>

    <script>
        $('#messageModal').on('shown', function () {
            $('#memberNoTextBox').focus();
        })
    </script>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Scripts/custom.css" rel="stylesheet" />

</body>
</html>
