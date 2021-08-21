using System;
using System.Collections;
using System.Text;
using ConsoleAppPProject.Models;
using NewProekt.Services;

namespace ConsoleAppPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager humanResourceManager = new HumanResourceManager();
            baseWord(humanResourceManager);
        }

        #region baseWord
        static void baseWord(HumanResourceManager humanResourceManager)
        {
            do
            {
                Console.WriteLine("1- Departmentle bagli emeliyyatlar  ucun");
                Console.WriteLine("2- Iscilerle bagli emeliyyatlar ucun");

                string choose = Console.ReadLine();
                int chooseNumbers;

                int.TryParse(choose, out chooseNumbers);
                switch (chooseNumbers)
                {
                    case 1:
                        DepartmentWork(humanResourceManager);
                        break;

                    case 2:
                        EmployeeWork(humanResourceManager);
                        break;

                    default:
                        Console.Clear();
                        break;
                }

            } while (true);
        }
        #endregion

        #region DepartmentWork
        static void DepartmentWork(HumanResourceManager humanResourceManager)
        {
            do
            {
                Console.WriteLine("1 - Departmentdeki siyahini gostermek ucun");
                Console.WriteLine("2 - Departmentde deyisiklik etmek ucun");
                Console.WriteLine("3 - Department yaratmaq ucun");
                Console.WriteLine("4 - Esas menyuya qayitmaq ucun");

                string choose = Console.ReadLine();
                int chooseNumbers;

                int.TryParse(choose, out chooseNumbers);
                switch (chooseNumbers)
                {
                    case 1:
                        GetDepartmentInformasiya(humanResourceManager);
                        break;

                    case 2:
                        editDepartment(humanResourceManager);
                        ;
                        break;

                    case 3:
                        createDepartment(humanResourceManager);
                        break;
                    case 4:
                        baseWord(humanResourceManager);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (true);
        }
        #endregion
        #region EmployeeWork
        static void EmployeeWork(HumanResourceManager humanResourceManager)
        {
            do
            {
                Console.WriteLine("1 - Iscilerin listinine baxmaq ucun");
                Console.WriteLine("2 - Departmentdeki iscilerin lsitini gostermek ucun");
                Console.WriteLine("3 - Isci elave etmek ucun");
                Console.WriteLine("4 - Isciler uzerinde deyisikler ucun");
                Console.WriteLine("5 - Departmentden isci silmek ucun");
                Console.WriteLine("6 - Esas menyuya qayitmaq ucun");

                string choose = Console.ReadLine();
                int chooseNumbers;
                    int.TryParse(choose, out chooseNumbers);
                switch (chooseNumbers)
                {
                    case 1:
                        GetEmployees(humanResourceManager);
                        break;

                    case 2:
                        getEmployeesInDepartment(humanResourceManager);
                        break;

                    case 3:
                        addEmployee(humanResourceManager);
                        break;
                    case 4:
                        editEmployee(humanResourceManager);
                        break;
                    case 5:
                        removeEmployee();
                        break;

                    case 6:
                        baseWord(humanResourceManager);

                        break;
                    default:
                        Console.Clear();
                        break;
                }

                } while (true) ;
            }
        #endregion
        #region GetDepartmentInformasiya
        static void GetDepartmentInformasiya(HumanResourceManager humanResourceManager)
        {
            humanResourceManager.GetDepartments(); 
        }
        #endregion
        #region createDepartment
        static void createDepartment(HumanResourceManager humanResourceManager)
        {
            Department department1 = new Department();
            bool check = false;
            while (!check)
            {
                Console.WriteLine("Departmentin adinin girin.");
                string DepartName = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa isci limiti girin");

                string empLimit = Console.ReadLine();
                int workerLimit;

                while (!int.TryParse(empLimit, out workerLimit))
                {
                    Console.WriteLine("Zehmet olmasa isci limiti girin!!!");
                    empLimit = Console.ReadLine();
                    int.TryParse(empLimit, out workerLimit);
                }
                Console.WriteLine("Iscinin maas limitini daxil edin");

                string salaryLimit = Console.ReadLine();
                int salaryCount;

                while (!int.TryParse(salaryLimit, out salaryCount))
                {
                    Console.WriteLine("Zehmet olmasa isci limiti girin!!!");
                    salaryLimit = Console.ReadLine();
                    int.TryParse(salaryLimit, out salaryCount);
                }
                department1.Name = DepartName;
                department1.SalaryLimit = salaryCount;
                department1.WorkerLimit = workerLimit;


                humanResourceManager.AddDepartment(department1);
                check = true;
            }


        }
        #endregion

        #region editDepartment
        static void editDepartment(HumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Axradiginiz departmentin adini girin!!!");
            string name = Console.ReadLine();

            Department department = humanResourceManager.Departments.Find(h => h.Name.ToLower() == name.ToLower());
            if (department == null)
            {
                Console.WriteLine("Daxil etdiyiniz adda department yoxdur!!!");
                return;
            }

            Console.WriteLine($"Departmentin adi: {department.Name} Deparmentin maas limiti: {department.SalaryLimit} Departmentin isci limiti: {department.WorkerLimit} ");
            Console.WriteLine("Departmentin yeni adi:");
            string newName = Console.ReadLine();
            Console.WriteLine("Departmentin maas limitini girin:");
            string salaryLimit = Console.ReadLine();
            int Salaryx;
            while (!int.TryParse(salaryLimit, out Salaryx))
            {
                Console.WriteLine("Departmentin maas limitini girin:");
                salaryLimit = Console.ReadLine();
                int.TryParse(salaryLimit, out Salaryx);
            }
            Console.WriteLine("Departmentin isci limitini girin");
            string empLimit = Console.ReadLine();
            int Limity;
            while (!int.TryParse(empLimit, out Limity))
            {
                Console.WriteLine("Departmentin isci limitini girin");
                empLimit = Console.ReadLine();
                int.TryParse(empLimit, out Limity);
            }

            department.Name = newName;
            department.SalaryLimit = Salaryx;
            department.WorkerLimit = Limity;

            Console.WriteLine("Department uzerinde olunan deyisiklik ugurla basa catdi");


        }
        #endregion




        #region GetEmployees
        static void GetEmployees(HumanResourceManager humanResourceManager)
        {
            for (int i = 0; i < humanResourceManager.Departments.Count; i++)
            {
                Department departmentEmployees = humanResourceManager.Departments[i];
                for (int a = 0; i < departmentEmployees.Employees.Count; a++)
                {
                    Console.WriteLine($"{departmentEmployees.Employees[i].No} {departmentEmployees.Employees[i].Fullname} {departmentEmployees.Employees[i].DepartmentName} {departmentEmployees.Employees[i].Salary}");
                }
            }
        }
        #endregion

        #region GetEmployeeinDepartment
        static void getEmployeesInDepartment(HumanResourceManager humanResourceManager)
        {

            Console.WriteLine("Zehmet olmasa departmentin adin daxil edin");
            string depName = Console.ReadLine();

            Department dep = humanResourceManager.Departments.Find(hd => hd.Name.ToLower() == depName.ToLower());

            if (dep != null)
            {

                for (int i = 0; i < dep.Employees.Count; i++)
                {
                    Console.WriteLine("P222 Canavarlari");
                    Console.WriteLine($"{dep.Employees[i].No} {dep.Employees[i].Fullname} {dep.Employees[i].Position} {dep.Employees[i].Salary}");
                }
            }

        }
        #endregion

        #region Employee
        static void addEmployee(HumanResourceManager humanResourceManager)
        {
            Employee emp1 = new Employee();

            Console.WriteLine("Fullname-i girin!!!");
            string fullname = Console.ReadLine();

            Console.WriteLine("Iscinin vezifesini daxil edin!!");
            string position = Console.ReadLine();

            Console.WriteLine("Maasini daxil edin!!!");
            string salary = Console.ReadLine();
            int salaryInt;
            while (!int.TryParse(salary, out salaryInt))
            {
                Console.WriteLine("Maawi daxil edin!!");
                salary = Console.ReadLine();
                int.TryParse(salary, out salaryInt);
            }

            Console.WriteLine("Departmanin adini daxil ediniz!!!");
            string DepartmanName = Console.ReadLine();

            emp1.Fullname = fullname;
            emp1.Salary = salaryInt;
            emp1.Position = position;

            humanResourceManager.AddEmployee(emp1, DepartmanName);
        }
        #endregion

        #region EditEmployee
        static void editEmployee(HumanResourceManager humanResourceManager)
        {

            Console.WriteLine("Deyisiklik  etmek ucun istediyiniz iscinin nomresini daxil edin!!!");
            string EmpNums = Console.ReadLine();
            int empNo;

            while (!int.TryParse(EmpNums, out empNo))
            {
                Console.WriteLine("Deyisiklik  etmek ucun istediyiniz iscinin nomresini daxil edin!!!");
                EmpNums = Console.ReadLine();
                int.TryParse(EmpNums, out empNo);
            }
        }
        #endregion

        #region removeEmployee
        static void removeEmployee()
        {

        }
        #endregion
    }
}
