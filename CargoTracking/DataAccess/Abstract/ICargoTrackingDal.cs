using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.DataAccess.Abstract
{
    public interface ICargoTrackingDal
    {
        List<Tracking> GetAll();
        void Add(Tracking cargoT);
        void Delete(Tracking cargoT);
        void Update(Tracking cargoT);
        List<Tracking> getById(int id);
    }
}
