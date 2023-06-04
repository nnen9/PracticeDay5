namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeBook EmployeeBook = new EmployeeBook();

            int cycle = 0;
            while (cycle == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Напишите номер метода (0 - выход, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        EmployeeBook.UpSalary(1.1);
                        break;
                    case 2:
                        EmployeeBook.MinSalaryOfDepartment();
                        break;
                    case 3:
                        EmployeeBook.MaxSalaryOfDepartment();
                        break;
                    case 4:
                        EmployeeBook.AverageSalaryOfDepartment();
                        break;
                    case 5:
                        EmployeeBook.UpSalaryForDepartment(1.1);
                        break;
                    case 6:
                        EmployeeBook.ShowEmployeeOfDepartment();
                        break;
                    case 7:
                        EmployeeBook.ShowSalaryLess();
                        break;
                    case 8:
                        EmployeeBook.ShowSalaryMore();
                        break;
                    case 9:
                        EmployeeBook.AddNewEmployee();
                        break;
                    case 10:
                        EmployeeBook.DeleteEmployee();
                        break;
                    case 11:
                        EmployeeBook.ChangeSalary();
                        break;
                    case 12:
                        EmployeeBook.ChangeDepartment();
                        break;
                    case 13:
                        EmployeeBook.ShowAllEmploeeSortDepartment();
                        break;
                }
            }
        }
    }
}