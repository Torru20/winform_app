using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class AccountDAL:Database
    {
        public string CheckLogin(Account acc)
        {
            string info = CheckLoginDTO(acc);
            return info;
        }
    }
}
