using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class Account_InfoBLL 
    {
        Account_InfoDAL AccDAL = new Account_InfoDAL();
        public string accountname {  get; set; }
        public string c = "Admin";
        
        public string getAccount(string x)
        {
            string b = x;
            c = x;
            return b;
        }
        public DataTable LoadAccountInfo(string _message)
        {
            DataTable dataTable = new DataTable();
            dataTable = AccDAL.LoadAccountInfo(_message);

            return dataTable;
        }
        public string UpdateAccountInfo(Account acc)
        {
            string info = AccDAL.UpdateAccountInfo(acc);
            return info;
        }
        public string UpdateAccountPassword(Account acc,string a,string b)
        {
            string info = "";
            if (a != b)
            {
                return "Mật khẩu mới nhập lại chưa trùng khớp !";
            }
            else if(acc.Password==a)
            {
                return "Mật khẩu mới trùng với mật khẩu cũ !";
            }
            info = AccDAL.UpdateAccountPassword(acc, a);
            return info;
        }
    }
}
