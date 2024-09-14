using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Account
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public int idAccess {  get; set; }
        public int idDepartment {  get; set; }
        public float Salary {  get; set; }
        public string Address { get; set; }
        public string Email {  get; set; }
    }
}
