using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class AssignDAL:Database
    {
        public DataTable LoadAccountNameCb()
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadAccountNameCbDTO();
            return dataTable;
        }

       
        public string AddNewTask(fTask task)
        {
            string test = "";
            test = AddNewTaskDTO(task);
            return test;
        }
        public string DeleteTask(fTask task)
        {
            string test = "";
            test = DeleteTaskDTO(task);
            return test;
        }
        public string UpdateTask(fTask task)
        {
            string test = "";
            if (task.TaskTimeOut ==DateTime.MinValue)
            {
                test = UpdateTaskDTO(task);
            }
            else
            {
                test = UpdateTaskDoneDTO(task);
            }
            
            return test;
        }
    }
}
