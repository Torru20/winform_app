using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    
    public class AddDepartmentBLL
    {
        AddDepartmentDAL addDAL = new AddDepartmentDAL();
        public DataTable LoadDepartmentList()
        {
            DataTable dt = new DataTable();
            dt = addDAL.LoadDepartmentList();
            return dt;
        }
        public string AddNewDepartment(Department dp)
        {
            string test="";
            if (dp.idDepartment == 0 || dp.DepartmentName == null)
            {
                return "Vui lòng điền đủ thông tin !";
            }
            test = addDAL.AddNewDepartment(dp);
            return test;
        }
        public string UpdateDepartment(Department dp)
        {
            string test = "";
            if (dp.idDepartment == 0 || dp.DepartmentName == null)
            {
                return "Vui lòng điền đủ thông tin !";
            }
            test = addDAL.UpdateDepartment(dp);
            return test;
        }
        public string DeleteDepartment(Department dp)
        {
            string test = "";
            if (dp.idDepartment == 0 )
            {
                return "Vui lòng điền đủ thông tin !";
            }
            test = addDAL.DeleteDepartment(dp);
            return test;
        }
    }
}
