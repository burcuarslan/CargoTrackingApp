using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        
        public User()
        {

        }
        public User(int UserId, String Name, String LastName, String PhoneNumber, String Email)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            
        }
    }
}
