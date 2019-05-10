using System;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kalle = new Employee("Kalle", 30000);
            Payroll payroll = new Payroll();

            Console.WriteLine("Mata in en anställd !");

            string name = Console.ReadLine();
            string input = Console.ReadLine();
            if (!int.TryParse(input , out int result))
            {
                Console.WriteLine("Felaktig input");
            }

            payroll.Add(name, result);

            Console.WriteLine(name);
            
        }
    }
}
