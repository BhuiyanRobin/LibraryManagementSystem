using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem.UI
{
    public partial class MainUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void borrowBooksButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("BorrowBookUI.aspx");
        }

        protected void returnBooksButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReturnBook.aspx");
        }
    }
}