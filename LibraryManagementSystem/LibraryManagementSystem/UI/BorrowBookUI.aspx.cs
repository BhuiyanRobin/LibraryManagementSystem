using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class BorrowBookUI : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllBooks();
            }
        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            string number = memberNoTextBox.Text;
            MemberBll aMemberBll = new MemberBll();
            BookEnroll aBookEnroll = new BookEnroll();
            BookBLL aBookBll=new BookBLL();
            if (aMemberBll.CheckMemberExistance(number)==true)
            {
                messageLable.Text = "";
                BorrowBookBll aBorrowBookBll = new BorrowBookBll();
                
                aBookEnroll.BookID = (int)ViewState["bookId"];
                aBookEnroll.MemberNumber = number;
                if (aBookBll.CheckBookDuplication(aBookEnroll)==true)
                {
                    messageLabel.Text = "This book already you take";
                }
                else
                {
                    messageLabel.Text = "";
                    aBorrowBookBll.Save(aBookEnroll);
                }
                
               
            }
            else
            {
                messageLable.Text = "This Member Number doesn't exist";
            }
            
        }

        public void LoadAllBooks()
        {
            BookBLL aBookBll = new BookBLL();
            allBooksDropDownList.DataSource = aBookBll.GetAllBooks();
            allBooksDropDownList.DataTextField = "Title";
            allBooksDropDownList.DataValueField = "Id";
            allBooksDropDownList.DataBind();
        }

        protected void allBooksDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book aBook = new Book();
            BookBLL aBookBll = new BookBLL();
            int index = allBooksDropDownList.SelectedIndex;
            aBook = aBookBll.GetAllBooks()[index];
            ViewState["bookId"] = aBook.Id;
            authorTextBox.Text = aBook.Author;
            publisherTextBox.Text = aBook.Publisher;



        }

        protected void allBooksDropDownList_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}