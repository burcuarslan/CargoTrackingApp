using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace CargoTrackingApp.DataAccess.Concrete
{
    public class CargoTrackingDal : ICargoTrackingDal
    {
        List<Tracking> _cargos;
        public CargoTrackingDal()
        {
            _cargos = new List<Tracking>();
            var c = File.ReadAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\Tracking.json");
            var objectList = JsonConvert.DeserializeObject<List<Tracking>>(c);
            foreach (var obj in objectList)
            {
                _cargos.Add(obj);
            }

        }
        
        public void Add(Tracking cargoT)
        {
            _cargos.Add(cargoT);

            string json = JsonConvert.SerializeObject(_cargos.ToArray());
            File.WriteAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\Tracking.json", json);

        }

        public void Delete(int cargoId)
        {

            Tracking cargoToDelete = _cargos.SingleOrDefault(c => c.CargoTrackingId == cargoId);
            _cargos.Remove(cargoToDelete);
            string json = JsonConvert.SerializeObject(_cargos.ToArray());
            File.WriteAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\Tracking.json", json);
        }


        public List<Tracking> GetAll()
        {
            return _cargos;
        }


        public List<Tracking> getById(int id)
        {
            
            if (_cargos.Where(c => c.CargoTrackingId == id).Count()==0)
            {
                return null;
            }
            else
            {
                return _cargos.Where(c => c.CargoTrackingId == id).ToList();
            }
            

        }


        public void Update(Tracking cargoT)
        {
            Tracking cargoUpdate = _cargos.SingleOrDefault(c => c.CargoTrackingId == cargoT.CargoTrackingId);
            
            cargoUpdate.SenderName = cargoT.SenderName;
            cargoUpdate.SenderSurName = cargoT.SenderSurName;
            cargoUpdate.SenderPhoneNumber = cargoT.SenderPhoneNumber;
            cargoUpdate.SenderEmail = cargoT.SenderEmail;
            cargoUpdate.SenderAddress = cargoT.SenderAddress;
          
            cargoUpdate.ReceiverName = cargoT.ReceiverName;
            cargoUpdate.ReceiverSurname = cargoT.ReceiverSurname;
            cargoUpdate.ReceiverPhoneNumber = cargoT.ReceiverPhoneNumber;
            cargoUpdate.ReceiverAddress = cargoT.ReceiverAddress;

            cargoUpdate.CargoTrackingId = cargoT.CargoTrackingId;
            cargoUpdate.CargoStatus = cargoT.CargoStatus;
            cargoUpdate.CargoWeight=cargoT.CargoWeight;
            cargoUpdate.CargoCost=cargoT.CargoCost;
            string json = JsonConvert.SerializeObject(_cargos.ToArray());
            File.WriteAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\Tracking.json", json);
        }
    }
}