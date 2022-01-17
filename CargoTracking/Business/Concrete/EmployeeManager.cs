using CargoTracking.Business.Abstract;
using CargoTracking.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _service;
        public EmployeeManager(IEmployeeDal service)
        {
            _service = service; 
        }
        public void Add(Employee employee)
        {
            _service.Add(employee);
        }

        public bool CheckEmployee(string email, string password)
        {
            return _service.CheckEmployee(email, password);
        }

        public void Delete(int employeeId)
        {
            _service.Delete(employeeId);
        }

        public List<Employee> GetAll()
        {
            return _service.GetAll();
        }


        public void Update(Employee employee)
        {
            _service.Update(employee);
        }
    }
}
