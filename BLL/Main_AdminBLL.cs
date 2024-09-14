using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class Main_AdminBLL
    {
        Main_AdminDAL Main_AdminDAL = new Main_AdminDAL();
        public DataTable LoadAttendance()
        {
            DataTable dt = new DataTable();
            dt = Main_AdminDAL.LoadAttendance();
            return dt;
        }
        public DataTable LoadAttendanceByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            dt = Main_AdminDAL.LoadAttendanceByDate(date);
            return dt;
        }
    }
}
