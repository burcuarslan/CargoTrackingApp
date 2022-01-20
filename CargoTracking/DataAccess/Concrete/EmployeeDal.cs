using CargoTracking.DataAccess.Abstract;
using CargoTrackingApp.Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTracking.DataAccess.Concrete
{
    public class EmployeeDal : IEmployeeDal
    {
        List<Employee> _employees;
        string dir = Application.StartupPath;
        public EmployeeDal()
        {
            _employees = new List<Employee>();
            var c = File.ReadAllText(dir + "/JsonFiles/Employee.json");
            var objectList = JsonConvert.DeserializeObject<List<Employee>>(c);
            foreach (var obj in objectList)
            {
                _employees.Add(obj);
            }
        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);

            string json = JsonConvert.SerializeObject(_employees.ToArray());
            File.WriteAllText(dir + "/JsonFiles/Employee.json", json);
        }
        
        public bool CheckEmployee(string email, string password)
        {
            Employee employeeToCheck = _employees.SingleOrDefault(c => c.Email == email);
            if (employeeToCheck==null)
            {
                return false;
            }
            else if (employeeToCheck.Password==password)
            { 
                return true;
            }
            return false;
        }

        public void Delete(int employeeId)
        {
            Employee employeeToDelete = _employees.SingleOrDefault(c => c.EmployeeId == employeeId);
            _employees.Remove(employeeToDelete);
            string json = JsonConvert.SerializeObject(_employees.ToArray());
            File.WriteAllText(dir + "/JsonFiles/Employee.json", json);
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }



        public void Update(Employee employee)
        {
            Employee employeeToUpdate = _employees.SingleOrDefault(c => c.EmployeeId == employee.EmployeeId);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Password = employee.Password;
            string json = JsonConvert.SerializeObject(_employees.ToArray());
            File.WriteAllText(dir + "/JsonFiles/Employee.json", json);
        }
    }
}
