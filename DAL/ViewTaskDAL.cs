using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class ViewTaskDAL:Database
    {
        public DataTable LoadListTask()
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadListTaskDTO();
            return dataTable;
        }
        public DataTable LoadListTaskbyInfo(DateTime date)
        {
            DataTable dataTable = new DataTable();
            dataTable=LoadListTaskbyInfoDTO(date);
            return dataTable;
        }
        public DataTable LoadListTaskbyInfo1(DateTime date, string st)
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadListTaskbyInfoDTO1(date,st);
            return dataTable;
        }
    }
}
