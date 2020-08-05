using ConsoleApp1;
using System;

public delegate bool HelloWorld(Employee emp,string pattern);
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 check = 'Y';
            //HelloWorld ns1 = new HelloWorld(Sample.HelloWorldFunction);
            //do {
                Sample obj = new Sample();
            //    string pattern = Console.ReadLine();
            //    foreach (Employee item in obj.Employees)
            //    {
            //        if (ns1(item, pattern))
            //        {
            //            Console.WriteLine("Id :- {0} Name :- {1} Department :- {2}", item.Id, item.Name, item.Department);
            //        }
            //    }
            //    Console.WriteLine("do you want search more [Y/N] Y");
            //    check = Console.Read();
            //} while (check == 'Y' || check == 'y');
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            obj.Description(1,2,3,4,5,6,7);
            obj.Description(arr);
        }
    }
}
