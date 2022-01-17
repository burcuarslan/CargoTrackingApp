using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Employee()
        {

        }
        public Employee(int EmployeeId,string Email,string Password)
        {
            this.EmployeeId = EmployeeId;
            this.Email = Email;
            this.Password = Password;
        }
    }
   
}
