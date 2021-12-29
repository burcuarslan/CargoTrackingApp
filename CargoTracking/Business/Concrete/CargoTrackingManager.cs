using CargoTrackingApp.Business.Abstract;
using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Business.Concrete
{
    public class CargoTrackingManager : ICargoTrackingService
    {
        ICargoTrackingDal _cargoDal;
        public CargoTrackingManager(ICargoTrackingDal cargoDal)
        {
            _cargoDal = cargoDal;
        }

        public void Add(Tracking cargoT)
        {
            _cargoDal.Add(cargoT);
        }

        public void Delete(Tracking cargoT)
        {
            _cargoDal.Delete(cargoT);
        }

        public List<Tracking> GetAll()
        {
           return  _cargoDal.GetAll();
        }

        public List<Tracking> GetById(int id)
        {
            return _cargoDal.getById(id);
        }

        public void Update(Tracking cargoT)
        {
            _cargoDal.Update(cargoT);
        }
    }
}
