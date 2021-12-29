using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class Tracking:Cargo
    {
        public int CargoTrackingId { get; set; }
        public String CargoStatus { get; set; }
        public Tracking()
        {

        }
        public Tracking(int UserId,String Name,String LastName,String PhoneNumber,String Email,int CargoId,String SendingAddress, String ReceivingAddress, int CargoTrackingId,string CargoStatus): base(UserId, Name, LastName, PhoneNumber,Email,CargoId,SendingAddress,ReceivingAddress)
        {
            this.CargoTrackingId = CargoTrackingId;
            this.CargoStatus = CargoStatus;
        }
    }
}
