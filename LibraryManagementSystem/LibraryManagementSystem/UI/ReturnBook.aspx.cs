using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.UI
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        BorrowBookEnroll aBorrowBookEnroll = new BorrowBookEnroll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showBorrowButton_Click(object sender, EventArgs e)
        {
            string number = memberNumberTextBox.Text;
            
            
            bookListDropDownList.DataSource = aBorrowBookEnroll.TakenBooks(number);

            bookListDropDownList.DataTextField = "Title";
            bookListDropDownList.DataValueField = "Id";
            bookListDropDownList.DataBind();
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            BookEnroll aBookEnroll=new BookEnroll();
            BorrowBookBll aBorrowBookBll=new BorrowBookBll();
            aBookEnroll.MemberNumber = memberNumberTextBox.Text;
            int index = bookListDropDownList.SelectedIndex;
            Book aBook = aBorrowBookEnroll.TakenBooks(aBookEnroll.MemberNumber)[index];
            aBookEnroll.BookID = aBook.Id;
            aBorrowBookBll.ReturnBook(aBookEnroll);
        }
    }
}