using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPProject.Models
{
    class Employee
    {
        private static int _counter = 1000;

       

        public Employee()
        {
            _counter++;
            No = DepartmentName.Substring(0, 2).ToUpper() + _counter;
        }

        public string No { get; set; }

        public string Fullname { get; set; }

        private string _position;

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (correctName(value))
                {
                    _position = value;
                }
                else
                {
                    Console.WriteLine("Iscinin vezifesi (minimum 2 herfden ibaret olmalidir!!!)");
                }
            }
        }

        private bool correctName(string name)
        {
            if (name.Length<=2)
            {
                return false;
            }
            foreach (char item in name)
            {
                if (!char.IsLetter(item))
                {

                }return false;
            }
            return true;
        }

        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
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
