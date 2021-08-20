using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Models
{
    class Department
    {
        private string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (Name.Length>=2)
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Department adi minimum 2 herfden ibaret olmalidir");
                }
            }
        }

        public int WorkerLimit
        {
            get
            {
                return WorkerLimit;
            }
            set
            {
                if (value>=1)
                {
                    WorkerLimit = value;
                }
                else
                {
                    Console.WriteLine("Departmentde minimum  var ola bilecek isci sayi 1 ola biler");
                }
            }
        }

        public int SalaryLimit
        {
            get
            {
                return SalaryLimit;
            }
            set
            {
                if (value>=250)
                {
                    SalaryLimit = value;
                }
                else
                {
                    Console.WriteLine("Departamentde butun isceleri ayliq cemi verilecek mebleg minimum 250 ola biler");
                }
            }
        }

        public List<Employee>Employees { get; set; }

        public double CalcSalaryAverage()
        {
            double sum = 0;
            double average = 0;
            foreach (var item in Employees)
            {
                sum += item.Salary;
            }
            if (Employees.Count !=0)
            {
                average = sum / Employees.Count;
                return average;
            }
            else
            {
                return 0;
            }
        }                                                  
    }
}
