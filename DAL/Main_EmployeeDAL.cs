using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using DTO;
namespace DAL
{
    public class Main_EmployeeDAL:Database
    {
        public DataTable LoadDataAttendanceByAccName(string k)
        {
            DataTable dtAttendance = new DataTable();
            dtAttendance = LoadDataAttendanceByAccNameDTO(k);
            return dtAttendance;
        }
        public string AttendanceByDate(string k,DateTime date)
        {
            string test = "";
            test = AttendanceByDateDTO(k,date);
            return test;
        }
    }
}
