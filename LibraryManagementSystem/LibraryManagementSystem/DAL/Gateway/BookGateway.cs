using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.Gateway
{
    public class BookGateway
    {
        private string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }

        public List<Book> GetAllBookList()
        {
            List<Book> BookList = new List<Book>();
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT * FROM t_book");

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Book aBook = new Book();
                    aBook.Id = (int) aReader[0];
                    aBook.Title = aReader[1].ToString();
                    aBook.Author = aReader[2].ToString();
                    aBook.Publisher = aReader[3].ToString();
                    BookList.Add(aBook);
                }
            }
            aConnection.Close();
            return BookList;
        }

        public bool CheckBookDuplication(BookEnroll aBookEnroll)
        {
            SqlConnection aConnection=new SqlConnection(Connection());

            string query = string.Format("Select* from t_book_enroll where book_id={0} and member_id='{1}'",
                aBookEnroll.BookID, aBookEnroll.MemberNumber);

            SqlCommand aCommand=new SqlCommand(query,aConnection);

            aConnection.Open();

            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }
}