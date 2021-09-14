using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Khaled", Email = "khaled@gmail.com", Department = Dept.HR },
                new Employee() {Id = 2, Name = "Wael", Email = "wael@gmail.com", Department = Dept.IT },
                new Employee() {Id = 3, Name = "Ismail", Email = "som3a@gmail.com", Department = Dept.Payroll },
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id); 
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

    }
}
