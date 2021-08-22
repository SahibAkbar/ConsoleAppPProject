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
                    if (true)
                    {
                        item.Employees.Add(employee1);
                        Console.WriteLine("Isci sirkete elave olundu tesekkurler");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name}  departamentde  isci ucun qalan yermiz yoxdur basqa vaxd gelersiz");
                    }
                }
            }
        }

        public void EditDepartaments(string Name,Department department)
        {
            foreach (Department department1 in _departments)
            {
                if (department1.Name.ToLower()==Name.ToLower())
                {
                    department1.Name = department.Name;
                }
                else
                {
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("Axtardiginiz adda department yoxdur");
                    Console.WriteLine("-------------------------------------\n");
                }
            }
        }

        public void EditEmployee(string num, string fullname, int salary, string position, Employee employee)
        {
            Employee employee1 = new Employee();
            foreach (Department item in _departments)
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    if (item.Employees[i].No == num)
                    {
                      
                        Console.WriteLine($"{item.Employees[i].Fullname}{item.Employees[i].Salary}  {item.Employees[i].Position}");

                        employee1.Salary = employee.Salary;
                        employee1.Position = employee.Position;

                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz adda isci yoxdur Tesekkurler");
                        return;
                    }
                }
            }
        }

        public List<Department> GetDepartments()
        {
            return Departments;
            Console.WriteLine("P222 Canavarlarina esq olsun");
        }

        public void RemoveEmployee(string num, string departmentName)
        {
            foreach (Department item in _departments)
            {
                if (item.Name.ToLower() == departmentName.ToLower())
                {
                    for (int i = 0; i < item.Employees.Count; i++)
                    {
                        if (item.Employees[i].No == num)
                        {
                            item.Employees.Remove(item.Employees[i]);
                            Console.WriteLine("Sildiyiniz isci departmentde ugurla vidalasdi :)");
                        }
                        else
                        {
                            Console.WriteLine("Axtardiginiz isci yoxdur!!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Axtardiginiz adda department yoxdur!!!");
                }
            }
        }

    }
}
