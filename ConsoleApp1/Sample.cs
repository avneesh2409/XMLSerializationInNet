using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp1
{
    public partial class Sample
    {
        public Sample() {
            Employees = new List<Employee> {
            new Employee{ Id=1,Name="Naman Dubey",Department="IT"},
            new Employee{ Id=2,Name="Naman1 Dubey",Department="IT" },
            new Employee{  Id=3,Name="Naman2 Dubey",Department="IT"},
            new Employee{  Id=4,Name="Naman3 Dubey",Department="IT"},
            new Employee{  Id=5,Name="Naman4 Dubey",Department="IT"}
        };
        }
         
    }
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

}
