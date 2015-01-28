using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.Gateway
{
    public class BorrowBookEnroll
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }

        public void InsertIntoDatabase(BookEnroll aBookEnroll)
        {
            SqlConnection aConnection=new SqlConnection(Connection());

            string query = string.Format("INSERT INTO t_book_enroll VALUES({0},'{1}')", aBookEnroll.BookID,
                aBookEnroll.MemberNumber);
            SqlCommand aCommand=new SqlCommand(query,aConnection);
            aConnection.Open();
            aCommand.ExecuteNonQuery();
            aConnection.Close();
        }
         public List<Book> TakenBooks(string number)
        {
            SqlConnection aConnection=new SqlConnection(Connection());
            List<Book>BookList=new List<Book>();
            List<int>ids=new List<int>();
            string query = string.Format("select*from t_book_enroll where member_id='{0}'", number);

            SqlCommand aCommand=new SqlCommand(query,aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    int bookId = (int) aReader[1];
                    ids.Add(bookId);
                }
            }
            aConnection.Close();
            foreach (int bookId in ids)
            {
                query = string.Format("select*from t_book where id='{0}'", bookId);
                aConnection.Open();
                aCommand=new SqlCommand(query,aConnection);
                aReader = aCommand.ExecuteReader();
                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        Book aBook = new Book();
                        aBook.Id = (int)aReader[0];
                        aBook.Title = aReader[1].ToString();
                        aBook.Author = aReader[2].ToString();
                        aBook.Publisher = aReader[3].ToString();
                        BookList.Add(aBook);
                    }
                }
                aConnection.Close();
            }
            return BookList;
        }

        public void ReturnBook(BookEnroll aBookEnroll)
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            string query = string.Format("Delete from t_book_enroll where book_id={0} and member_id='{1}'", aBookEnroll.BookID, aBookEnroll.MemberNumber);

            SqlCommand aCommand=new SqlCommand(query,aConnection);
            aConnection.Open();
            aCommand.ExecuteNonQuery();
        }
    
    }
}