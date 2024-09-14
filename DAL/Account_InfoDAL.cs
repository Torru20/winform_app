using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
namespace DAL
{
    public class Account_InfoDAL:Database
    {
        public DataTable LoadAccountInfo(string x)
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadAccountInfoDTO(x);
            return dataTable;
        }
        public string UpdateAccountInfo(Account acc)
        {
            string info= UpdateAccountInfoDTO(acc);
            return info;
        }
        public string UpdateAccountPassword(Account acc,string a)
        {
            string info= UpdateAccountPasswordDTO(acc,a); 
            return info;
        }
    }
}
