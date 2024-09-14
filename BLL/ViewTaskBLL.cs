using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class ViewTaskBLL
    {
        ViewTaskDAL viewDAL=new ViewTaskDAL();
        public DataTable LoadListTask()
        {
            DataTable dataTable = new DataTable();
            dataTable = viewDAL.LoadListTask();
            return dataTable;
        }
        public DataTable LoadListTaskbyInfo(DateTime date,string st)
        {
            DataTable dataTable = new DataTable();
            if (st == "...")
            {
                dataTable = viewDAL.LoadListTaskbyInfo(date);
            }
            else
            {
                dataTable = viewDAL.LoadListTaskbyInfo1(date,st);
            }
            return dataTable;
        }
    }
}
