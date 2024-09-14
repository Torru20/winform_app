using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class AddEmployeeBLL
    {
        AddEmployeeDAL AddEmployee = new AddEmployeeDAL();
        public DataTable LoadEmployeeList()
        {
            DataTable ds = new DataTable();
            ds=AddEmployee.LoadEmployeeList();
            return ds;
        }

        public DataTable LoadDepartment()
        {
            DataTable ds = new DataTable();
            ds=AddEmployee.LoadDepartment();
            return ds;
        }

        public int getDepartmentID(string x)
        {
            int i;
            i = AddEmployee.getDepartmentID(x);
            return i;
        }
        public string AddNhanVien(Account acc)
        {
            string checkstr="";
            if(acc.AccountName==null  ||acc.idDepartment==0|| acc.Salary == 0)
            {
                return "Vui lòng điền thông tin bắt buộc !";
            }
            AddEmployeeDAL acc1=new AddEmployeeDAL();
            checkstr =acc1.AddNhanVien(acc);
            return checkstr;
        }
        public string DeleteNhanVien(Account acc)
        {
            string checkstr = "";
            if(acc.AccountName==null)
            {
                return "Vui lòng chọn nhân viên muốn xóa";
            }
            AddEmployeeDAL acc1 = new AddEmployeeDAL();
            checkstr = acc1.DeleteNhanVien(acc);
            return checkstr;
        }
        public string UpdateNhanVien(Account acc)
        {
            string checkstr = "";
            if (acc.AccountName == null || acc.idDepartment == 0 || acc.Salary == 0||acc.idAccess==0)
            {
                return "Vui lòng điền thông tin bắt buộc !";
            }
            AddEmployeeDAL acc1 = new AddEmployeeDAL();
            checkstr = acc1.UpdateNhanVien(acc);
            return checkstr;
        }
    }
}
