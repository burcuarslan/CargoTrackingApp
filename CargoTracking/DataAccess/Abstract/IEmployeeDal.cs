using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.DataAccess.Abstract
{
    public interface IEmployeeDal
    {
        List<Employee> GetAll();
        void Add(Employee employee);
        void Delete(int employeeID);
        void Update(Employee employee);
        bool CheckEmployee(string email,string password);
    }
}
