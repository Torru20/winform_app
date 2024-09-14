using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class AssignBLL
    {
        AssignDAL assDAL=new AssignDAL();
        public DataTable LoadAccountNameCb()
        {
            DataTable dataTable = new DataTable();
            dataTable = assDAL.LoadAccountNameCb();
            return dataTable;
        }

    
        public string AddNewTask(fTask t)
        {
            string test = "";
            if(t.TaskName=="")
            {
                return "Vui lòng nhập tên nhiệm vụ !";
            }
            if (t.AccountName == "")
            {
                return "vui lòng nhập tên người thực hiện !";
            }
            test = assDAL.AddNewTask(t);


            return test;
        }
        public string DeleteTask(fTask t)
        {
            string test = "";
            if (t.TaskName == "")
            {
                return "Vui lòng nhập tên nhiệm vụ !";
            }
            if (t.AccountName == "")
            {
                return "vui lòng nhập tên người thực hiện !";
            }
            test = assDAL.DeleteTask(t);
            return test;
        }
        public string UpdateTask(fTask t)
        {
            string test = "";
            if (t.TaskName == "")
            {
                return "Vui lòng nhập tên nhiệm vụ !";
            }
            if (t.AccountName == "")
            {
                return "vui lòng nhập tên người thực hiện !";
            }
            test = assDAL.UpdateTask(t);
            return test;
        }
    }
}
