using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    public class BookBLL
    {
        BookGateway aBookGateway = new BookGateway();
        public List<Book> GetAllBooks()
        {
            
            return aBookGateway.GetAllBookList();
        }

        public bool CheckBookDuplication(BookEnroll aBookEnroll)
        {
            return aBookGateway.CheckBookDuplication(aBookEnroll);
        }
    }
}