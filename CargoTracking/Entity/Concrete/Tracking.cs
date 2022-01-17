using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Entity.Concrete
{
    public class Tracking
    {
        public string SenderName { get; set; }
        public string SenderSurName { get; set; }
        public string SenderPhoneNumber { get; set; }
        public string SenderEmail { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSurname { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public int CargoTrackingId { get; set; }
        public string CargoStatus { get; set; }
        public int CargoWeight { get; set; }
        public int CargoCost { get; set; }
        public Tracking()
        {

        }
        public Tracking(string SenderName, string SenderSurname, string SenderPhoneNumber, string SenderEmail, string SenderAddress, string ReceiverName, string ReceiverSurname, string ReceiverAddress, string ReceiverPhoneNumber, int CargoTrackingId, string CargoStatus, int CargoWeight, int CargoCost)
        {
            this.SenderName = SenderName;
            this.SenderSurName = SenderSurname;
            this.SenderPhoneNumber = SenderPhoneNumber;
            this.SenderEmail = SenderEmail;
            this.SenderAddress = SenderAddress;
            this.ReceiverName = ReceiverName;
            this.ReceiverSurname = ReceiverSurname;
            this.ReceiverAddress = ReceiverAddress;
            this.ReceiverPhoneNumber = ReceiverPhoneNumber;
            this.CargoTrackingId = CargoTrackingId;
            this.CargoStatus = CargoStatus;
            this.CargoWeight = CargoWeight;
            this.CargoCost = CargoCost;

        }
    }
}
