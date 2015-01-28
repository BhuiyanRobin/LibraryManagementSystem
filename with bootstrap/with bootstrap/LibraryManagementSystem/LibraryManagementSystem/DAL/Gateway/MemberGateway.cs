using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.DAL.Gateway
{
    public class MemberGateway
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }

        public bool ChkMemebrExistance(string number)
        {
            SqlConnection aConnection=new SqlConnection(Connection());

            string query = string.Format("SELECT*FROM t_member WHERE number='{0}'", number);

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