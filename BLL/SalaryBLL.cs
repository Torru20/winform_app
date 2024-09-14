using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class SalaryBLL
    {
        SalaryDAL slDAL = new SalaryDAL();
        public DataTable LoadSalaryList(int m)
        {
            DataTable dt = new DataTable();
            dt = slDAL.LoadSalaryList(m);
            return dt;
        }
    }
}
