
using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTrackingApp.Business.Abstract
{
    public interface ICargoTrackingService
    {
        List<Tracking> GetAll();
        List<Tracking> GetById(int id);
        void Add(Tracking cargoT);
        void Delete(Tracking cargoT);
        void Update(Tracking cargoT);

    }
}
