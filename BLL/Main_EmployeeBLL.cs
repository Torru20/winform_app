using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class Main_EmployeeBLL
    {
        Main_EmployeeDAL main_EmployeeDAL = new Main_EmployeeDAL();
        public DataTable LoadDataAttendanceByAccName(string k)
        {
            DataTable dt = new DataTable();
            dt= main_EmployeeDAL.LoadDataAttendanceByAccName(k);
            return dt;
        }
        public string AttendanceByDate(string k,DateTime date)
        {
            string test = "";
            test = main_EmployeeDAL.AttendanceByDate(k,date);
            return test;
        }
    }
}
