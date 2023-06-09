using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Nguyen", "Hien", "Hanoi, Vietnam", 1234567890, 500000);

            double bonus = employee.CalculateBonus(10);
            Console.WriteLine($"Bonus: {bonus:$}");

            Console.WriteLine(employee.ToString());

            Console.ReadLine();
        }
    }
}