using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Models
{
    class Employee
    {
        private static int _counter = 1000;

        public string No { get; set; }

        public Employee()
        {
            _counter++;
            No = DepartmentName.Substring(0, 2).ToUpper() + _counter;
        }

        public string Fullname { get; set; }

        public string Position
        {
            get
            {
                return Position;
            }
            set
            {
                if (Position.Length>=2)
                {
                    Position = value;
                }
                else
                {
                    Console.WriteLine("Iscinin vezifesi (minimum 2 herfden ibaret olmalidir)");
                }
            }
        }


        public int Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value>=250)
                {
                    Salary = value;
                }
                else
                {
                    Console.WriteLine("Iscinin maasi 250-den asagi ola bilmez");
                }
            }
        }

        public string DepartmentName { get; set; }
    }
}
