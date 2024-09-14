using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using DTO;

namespace DAL
{
    public class SalaryDAL:Database
    {
        public DataTable LoadSalaryList(int m)
        {
            DataTable dt = new DataTable();
            dt = LoadSalaryListDTO(m);
            return dt;
        }
    }
}
