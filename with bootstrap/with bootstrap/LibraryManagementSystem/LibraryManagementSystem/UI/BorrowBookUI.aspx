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
            <div>

<%--                <asp:Label ID="Label1" runat="server" Text="Member Number"></asp:Label>--%>

                <div>
                    <asp:TextBox CssClass="form-control col-lg-3" placeholder="Member No" ID="memberNoTextBox" runat="server" Width="300"></asp:TextBox>
                    <asp:Label ID="messageLable" runat="server"></asp:Label>
                </div>
            </div>
            
            <div style="width: 300px">
                
<%--                <asp:Label ID="Label2" runat="server" Text="Course List"></asp:Label>--%>
                <div>
                    <asp:DropDownList CssClass="form-control" ID="allBooksDropDownList" placeholder="Course List" runat="server" AutoPostBack="True" OnSelectedIndexChanged="allBooksDropDownList_SelectedIndexChanged" OnTextChanged="allBooksDropDownList_TextChanged" >
                    </asp:DropDownList>
<%--                    <asp:Label ID="messageLabel" runat="server"></asp:Label>--%>
                </div>
                </div>

            <div>
                
<%--            <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>--%>
                <div>
                <asp:TextBox CssClass="form-control" placeholder="Author" ID="authorTextBox" runat="server" Width="300"></asp:TextBox>
            </div>
                </div>
            <div>
                
<%--            <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>--%>
                <div>
            <asp:TextBox CssClass="form-control" ID="publisherTextBox" runat="server" Width="300"></asp:TextBox>
            </div>
                </div>
            
            <div>
                <asp:Button CssClass="customButton btn" ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
            </div>
                </div>
        </form>
    </div>


    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Scripts/custom.css" rel="stylesheet" />

</body>
</html>
