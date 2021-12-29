using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class Cargo:User
    {
        public int CargoId { get; set; }
        public String SendingAddress { get; set; }
        public String ReceivingAddress { get; set; }
        public Cargo()
        {

        }
        public Cargo(int UserId, String Name, String LastName, String PhoneNumber, String Email, int CargoId, String SendingAddress, String ReceivingAddress): base(UserId, Name, LastName, PhoneNumber,Email)
        {
            this.SendingAddress = SendingAddress;
            this.ReceivingAddress = ReceivingAddress;
        }

    }
}
