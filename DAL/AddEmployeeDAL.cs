using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class AddEmployeeDAL:Database
    {
        public DataTable LoadEmployeeList()
        {
            DataTable ds = new DataTable();
            ds=LoadEmployeeListDTO();
            return ds;
        }
        public DataTable LoadDepartment()
        {
            DataTable ds = new DataTable();
            ds = LoadDepartmentCB();
            return ds;
        }
        public int getDepartmentID(string x)
        {
            int i;
            i=getDepartmentIDDTO(x);
            return i;
        }
        public string AddNhanVien(Account acc)
        {
            string info = AddNhanVienDTO(acc);
            return info;
        }
        public string DeleteNhanVien(Account acc)
        {
            string info = DeleteNhanVienDTO(acc);
            return info;
        }
        public string UpdateNhanVien(Account acc)
        {
            string info = UpdateNhanVienDTO(acc);
            return info;
        }

    }
}
