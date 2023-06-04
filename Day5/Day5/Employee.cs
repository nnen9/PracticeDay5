using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Employee
    {
        private string _fio;
        private double _salary;
        private int _department;
        private int _id = 0;
        static int count;

        public int Id()
        {
            _id++;
            count = _id;
            return count;
        }

        public Employee(string fio, double salary, int department)
        {
            _fio = fio;
            _salary = salary;
            _department = department;
        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public int Department
        {
            get => _department;
            set => _department = value;
        }

        public int ClearId()
        {
            _id = 0;
            count = _id;
            return count;
        }
    }
}
