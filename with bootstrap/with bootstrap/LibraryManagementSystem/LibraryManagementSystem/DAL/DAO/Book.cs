using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.DAL.DAO
{
    public class Book
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public string Publisher { set; get; }
    }
}