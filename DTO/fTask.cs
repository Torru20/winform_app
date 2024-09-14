using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class fTask
    {
        public int idTask {  get; set; }
        public string TaskName { get; set; }
        public DateTime TaskTimeIn {  get; set; }
        public DateTime TaskTimeOut { get; set;}
        public string AccountName {  get; set; }
        public int idStatus {  get; set; }
    }
}
