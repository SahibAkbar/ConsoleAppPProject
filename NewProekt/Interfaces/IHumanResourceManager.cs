using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppPProject.Models;


namespace NewProekt.Interfaces
{
    interface IHumanResourceManager
    {
        public List<Department> Departments { get; }

        public void AddDepartment(Department department);

        public List<Department> GetDepartments();

        public void EditDepartaments(string Name, string newName);


        public void AddEmployee(Employee employee, string departmentName);

        public void RemoveEmployee(int num, string departmentName);
        public void EditEmployee(int num, string fullname, int salary, string position);
    }
}
