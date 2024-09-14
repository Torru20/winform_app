using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class AddDepartmentDAL:Database
    {
        public DataTable LoadDepartmentList()
        {
            DataTable dt = new DataTable();
            dt = LoadDepartmentListDTO();
            return dt;
        }
        public string AddNewDepartment(Department dp)
        {
            string test = "";
            test = AddNewDepartmentDTO(dp);
            return test;
        }
        public string UpdateDepartment(Department dp)
        {
            string test = "";
            test = UpdateDepartmentDTO(dp);
            return test;
        }
        public string DeleteDepartment(Department dp)
        {
            string test = "";
            test = DeleteDepartmentDTO(dp);
            return test;
        }
    }
}
