using System;
using System.Collections.Generic;
using System.Text;
using NewProekt.Interfaces;
using ConsoleAppPProject.Models;

namespace NewProekt.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        private List<Department> _departments;
        public List<Department> Departments
        {
            get
            {
                return _departments;
            }
        }

        private List<Employee> _employees;
        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }
        public HumanResourceManager()
        {
            _departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            _departments.Add(department);
        }

        public void AddEmployee(Employee employee, string departmentName)
        {
            Employee employee1 = new Employee();
            employee1.Fullname = employee.Fullname;
            employee1.Salary = employee.Salary;
            employee1.Position = employee.Position;

            foreach (Department item in Departments)
            {
                if (item.Name.ToLower() == departmentName.ToLower())
                {
                    item.Employees.Add(employee1);
                }
            }
        }

        public void EditDepartaments(string Name, string newName)
        {
        }

        public void EditEmployee(int num, string fullname, int salary, string position)
        {
        }

        public List<Department> GetDepartments()
        {
            return Departments;
            Console.WriteLine("P222 Canavarlarina esq olsun");
        }

        public void RemoveEmployee(int num, string departmentName)
        {
        }
    }
}
