using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    public class BorrowBookBll
    {
        BorrowBookEnroll aBookEnrollGateway = new BorrowBookEnroll();
        public void Save(BookEnroll aBookEnroll)
        {
            
            aBookEnrollGateway.InsertIntoDatabase(aBookEnroll);
        }

        public List<Book> GetTakenBook(string number)
        {
            return aBookEnrollGateway.TakenBooks(number);
        }

        public void ReturnBook(BookEnroll aBookEnroll)
        {
            aBookEnrollGateway.ReturnBook(aBookEnroll);
        }
    }
}