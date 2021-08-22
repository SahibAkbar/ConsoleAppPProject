﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPProject.Models
{
    class Employee
    {
        private static int _counter = 1000;

        public Employee()
        {
        }

        public Employee(string depart) : this()
        {
            DepartmentName = depart;
            _counter++;
            No = DepartmentName.Substring(0, 2).ToUpper() + _counter;
        }



        public string No;

        public string Fullname;

        private string _position;
        // iscinin vezifesi ucun method
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
            if (name.Length<2)
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
        //iscinin massi ucun method
        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Iscinin maasi 250-den asagi ola bilmez");
                }
            }
        }

        public string DepartmentName;
    }
}
