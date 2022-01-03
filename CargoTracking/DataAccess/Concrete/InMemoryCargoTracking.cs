using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CargoTrackingApp.DataAccess.Concrete
{
    public class InMemoryCargoTracking : ICargoTrackingDal
    {
        List<Tracking> _cargos;
        public IList<Tracking> _cargos2;
        public Object b;
        public Object c;
        public string[] jsonParts;
        public InMemoryCargoTracking()
        {
            string a = File.ReadAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data2.json");
            // b=JsonConvert.DeserializeObject(a);
            // var model = JsonConvert.DeserializeObject<Tracking>(a);

            jsonParts = Regex.Split(a.Replace("[", "").Replace("]", ""), "},{");

            _cargos = jsonParts.ToList<Tracking>();


            //string c = b.ToString();
            //string[] d = c.Split(',');

            _cargos = new List<Tracking>
            {
                new Tracking{ UserId=1, Name="burcu", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", CargoId=1, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=1,CargoStatus="yolda" },
                //new Tracking{ UserId=2, Name="zeynep", LastName="arslan", PhoneNumber="5442276917", Email="burcuarslln@gmail.com", CargoId=2, SendingAddress="slkrghşslkjgh", ReceivingAddress="slngslkjşhflsk",CargoTrackingId=2,CargoStatus="ürün teslim edildi" }

            };
            //string json = JsonConvert.SerializeObject(_cargos.ToArray());

            ////write string to file
            //System.IO.File.WriteAllText(@"C:\Users\burcu\source\repos\CargoTracking\CargoTracking\data.json", json);


        }

        public void Add(Tracking cargoT)
        {
            _cargos.Add(cargoT);
            string json = JsonConvert.SerializeObject(_cargos.ToArray());
            //File.OpenWrite(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data2.json");
            //write string to file
            //File.WriteAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data2.json", json);
            //string c = _cargos.ToArray().ToString();
            //File.WriteAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data3.json", c);
            File.AppendAllText(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data2.json", json);
            
            //var sw= new StreamWriter(@"C:\CargoTracking-main\CargoTracking-main\CargoTracking\data3.json", false);
            //sw.WriteLine(json);




        }

        public void Delete(int cargoId)
        {

            Tracking cargoToDelete = _cargos.SingleOrDefault(c => c.CargoId == cargoId);
            _cargos.Remove(cargoToDelete);
        }


        public List<Tracking> GetAll()
        {
            return _cargos;
        }


        public List<Tracking> getById(int id)
        {
            return _cargos.Where(c => c.CargoId == id).ToList();

        }


        public void Update(Tracking cargoT)
        {
            Tracking cargoUpdate = _cargos.SingleOrDefault(c => c.CargoId == cargoT.CargoId);
            cargoUpdate.CargoId = cargoT.CargoId;
            cargoUpdate.CargoStatus = cargoT.CargoStatus;
        }
    }
}