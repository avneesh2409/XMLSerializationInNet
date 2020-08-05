using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    public partial class Sample
    {
        private int _id;
        private string _name;
        private List<Employee> _employees;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public List<Employee> Employees {
            get {
                return _employees;
            }
            set {
                _employees = value;
            }
        }
    }
    public partial class Sample
    {
        public void ReadData()
        {
            Console.WriteLine("Id :- {0} Name :- {1}", Id, Name);
        }
        public void DisplayEmployee() {
            foreach (Employee item in Employees) {
                Console.WriteLine("Id :- {0} Name :- {1} Department :- {2}", item.Id, item.Name, item.Department);
            }
        }
        public static bool HelloWorldFunction(Employee employee,string pattern) {
            if (employee.Name.StartsWith(pattern))
            {
                return true;
            }
            else {
                return false;
            }
        }
        public  void Description(params int[] args) {
            foreach (int i in args) {
                Console.Write(" " + i + " ");
            }
        }
     
    }
}
