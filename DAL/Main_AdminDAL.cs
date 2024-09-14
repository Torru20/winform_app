using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
namespace DAL
{
    public class Main_AdminDAL:Database
    {
        public DataTable LoadAttendance()
        {
            DataTable dtAttendance = new DataTable();
            dtAttendance = LoadAttendanceDTO();
            return dtAttendance;
        }
        public DataTable LoadAttendanceByDate(DateTime date)
        {
            DataTable dtAttendance = new DataTable();
            dtAttendance = LoadAttendanceByDateDTO(date);
            return dtAttendance;
        }
    }
}
