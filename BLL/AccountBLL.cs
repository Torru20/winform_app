using System;
using System.Collections.Generic;
using System.Text;

using DTO;
using DAL;
namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accountDAL = new AccountDAL();
        public string CheckLogin(Account acc)
        {
            //ktra nghiep vu
            if (acc.AccountName == "")
            {
                return "Vui lòng không để trống tên tài khoản";
            }
            if (acc.Password == "")
            {
                return "Vui lòng không để trống mật khẩu";
            }
            if (acc.idAccess == 0)
            {
                return "Vui lòng không để trống chức vụ";
            }
            string info=accountDAL.CheckLogin(acc);
            return info;
        }
        
    }
}
