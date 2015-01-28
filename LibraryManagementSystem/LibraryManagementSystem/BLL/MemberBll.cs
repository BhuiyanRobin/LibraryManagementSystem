using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    public class MemberBll
    {
        public bool CheckMemberExistance(string number)
        {
            MemberGateway aMemberGateway=new MemberGateway();
            if (aMemberGateway.ChkMemebrExistance(number)==true)
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