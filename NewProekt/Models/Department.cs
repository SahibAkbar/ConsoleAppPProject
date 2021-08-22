using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPProject.Models
{
    class Department
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (correctName(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Departmentin adi minimum 2 herfden ibaret olmalidir!!!");
                }
            }
        }

        private bool correctName(string name)
        {
            if (name.Length <=  2)
            {
                return false;
            }

            foreach (char item in name)
            {
                if (!Char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

        private int _workerLimit;
        public int WorkerLimit
        {
            get
            {
                return _workerLimit;
            }
            set
            {
                if (value>=1)
                {
                    _workerLimit = value;
                }
                else
                {
                    Console.WriteLine("Departmentde minimum  var ola bilecek isci sayi 1 ola biler");
                }
            }
        }

        private int _salaryLimit;
        public int SalaryLimit
        {
            get
            {
                return _salaryLimit;
            }
            set
            {
                if (value>=250)
                {
                    _salaryLimit = value;
                }
                else
                {
                    Console.WriteLine("Departamentde butun iscelere ayliq cemi verilecek mebleg minimum 250 ola biler");
                }
            }
        }

        public List<Employee> _employees { get; set; }
        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }

        public Department()
        {
            _employees = new List<Employee>();
        }


        public double CalcSalaryAverage()
        {
            int salaryAverage = 0;

            foreach (Employee emp in Employees)
            {
                salaryAverage += emp.Salary;
            }

            salaryAverage /= Employees.Count;

            return salaryAverage;
        }
        public override string ToString()
        {
            return $"{Name} {Employees.Count} {CalcSalaryAverage()}";
        }
                                                      
    }
}
