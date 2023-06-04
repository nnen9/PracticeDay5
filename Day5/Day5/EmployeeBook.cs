using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class EmployeeBook
    {
        Employee employee = new Employee("fio", 10000, 1);
        List<Employee> employees = new List<Employee>()
        {
            new ("Мельникова Ксения Витальевна", 15000, 2),
            new ("Иванова София Ивановна", 21500, 1),
            new ("Буракшаева Юлия Сергеевна", 335050, 4),
            new ("Фурсова Елизавета Владимировна", 400000, 5),
            new ("Сапсай Иван Алексеевич", 23000, 1),
            new ("Богословский Артем Михайлович", 60000, 3),
            new ("Самбикина Юлия Владимировна", 410000, 5),
            new ("Шпак Ангелина Эдуардовна", 25000, 2),
            new ("Пименов Максим Евгеньевич", 40000, 3),
            new ("Сигида Валерия Романовна", 65000, 4)
        };

        public void UpSalary(double argument)
        {
            double up = 0;
            double arg = argument;
            foreach (var emp in employees)
            {
                up = emp.Salary * arg;
                Console.WriteLine("Зарплата " + emp.Fio + " повышена до " + up);
            }
        }

        public void MinSalaryOfDepartment()
        {
            Console.WriteLine("Напишите отдел для определения минимальной зарплаты: ");
            double department = Convert.ToDouble(Console.ReadLine());
            double min = 999999;
            foreach (var emp in employees)
            {
                if (emp.Salary < min)
                {
                    if (emp.Department == department)
                    {
                        min = emp.Salary;
                    }
                }
            }
            Console.WriteLine("Минимальная зарплата отдела: " + min);
        }

        public void MaxSalaryOfDepartment()
        {
            Console.WriteLine("Напишите отдел для определения максимальной зарплаты: ");
            double department = Convert.ToDouble(Console.ReadLine());
            double max = 0;
            foreach (var emp in employees)
            {

                if (emp.Salary > max)
                {
                    if (emp.Department == department)
                    {
                        max = emp.Salary;
                    }
                }
            }
            Console.WriteLine("Максимальная зарплата отдела: " + max);
        }

        public void AverageSalaryOfDepartment()
        {
            Console.WriteLine("Напишите отдел для определения средней зарплаты: ");
            int count = 0;
            double sum = 0;
            double department = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == department)
                {
                    count++;
                    sum += emp.Salary;
                }
            }
            Console.WriteLine($"Средняя зарплата отдела: {sum / count}");
        }

        public void UpSalaryForDepartment(double argument)
        {
            Console.WriteLine("Напишите отдел для увеличения зарплаты: ");
            double department = Convert.ToDouble(Console.ReadLine());
            double up = 0;
            double arg = argument;
            foreach (var emp in employees)
            {
                if (emp.Department == department)
                {
                    up = emp.Salary * arg;
                    Console.WriteLine("Зарплата " + emp.Fio + " увеличина до " + up);
                }
            }
        }

        public void ShowEmployeeOfDepartment()
        {
            Console.WriteLine("Напишите отдел для показа сотрудников: ");
            double department = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == department)
                {
                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                }
            }
        }

        public void ShowSalaryLess()
        {
            Console.WriteLine("Вывод зарплат меньше чем: ");
            double value = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Salary < value)
                {
                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                }
            }
        }

        public void ShowSalaryMore()
        {
            Console.WriteLine("Вывод зарплат больше чем: ");
            double value = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Salary > value)
                {
                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                }
            }
        }

        public void AddNewEmployee()
        {
            Console.Write("Напишите ФИО сотрудника: ");
            string fio = Console.ReadLine();
            Console.Write("Напишите зарплату сотрудника: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите отдел сотрудника: ");
            int department = Convert.ToInt32(Console.ReadLine());
            
            Employee employee = new Employee(fio, salary, department);
            employees.Add(employee);

            foreach(var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
        }

        public void DeleteEmployee()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
            Console.WriteLine();
            Console.WriteLine("Напишите ФИО сотрудника чтобы удалить: ");
            string fio = Console.ReadLine();
            foreach (var emp in employees)
            {
                if (emp.Fio == fio)
                {
                    employees.Remove(emp);
                    break;
                }
            }
            employee.ClearId();
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
        }

        public void ChangeSalary()
        {
            int newplaceinlist = 0;
            double salary = 0;
            int department = 0;
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
            Console.WriteLine();
            Console.WriteLine("Напишите ФИО сотрудника для изменения зарплаты: ");
            string fio = Console.ReadLine();
            int placeinlist = -1;
            foreach (var emp in employees)
            {
                placeinlist++;
                if (emp.Fio == fio)
                {
                    newplaceinlist = placeinlist;
                    salary = emp.Salary;
                    department = emp.Department;
                    employees.Remove(emp);
                    break;
                }
            }

            Console.WriteLine("Напишите новую зарплату сотрудника: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Employee newemployee = new Employee(fio, salary, department);
            employees.Insert(newplaceinlist, newemployee);
            employee.ClearId();

            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
        }

        public void ChangeDepartment()
        {
            int newplaceinlist = 0;
            double salary = 0;
            int department = 0;
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
            Console.WriteLine();
            Console.WriteLine("Напишите ФИО сотрудника для изменения отдела: ");
            string fio = Console.ReadLine();
            int placeinlist = -1;
            foreach (var emp in employees)
            {
                placeinlist++;
                if (emp.Fio == fio)
                {
                    newplaceinlist = placeinlist;
                    salary = emp.Salary;
                    department = emp.Department;
                    employees.Remove(emp);
                    break;
                }
            }

            Console.WriteLine("Напишите новый отдел сотрудника: ");
            department = Convert.ToInt32(Console.ReadLine());

            Employee newemployee = new Employee(fio, salary, department);
            employees.Insert(newplaceinlist, newemployee);
            employee.ClearId();

            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
        }

        public void ShowAllEmploeeSortDepartment()
        {
            for (int department = 1; department <= 5; department++)
            {
                int count = 0;
                foreach (var emp in employees)
                {
                    if (emp.Department == department)
                    {
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(emp.Department + " Отдел");
                            Console.WriteLine();
                        }
                        Console.WriteLine(emp.Fio + ", Зарплата: " + emp.Salary);
                    }
                }
            }
        }
    }
}
