using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TopCompanyPayload
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string position = Console.ReadLine();
            int hours = 0; 
            decimal moneyOnHour = 0;
            Employees st1 = new Employees(name, position, hours, moneyOnHour);
            st1.AddInDataBase(st1);
            Console.ReadLine();
            st1.GetListEmp(); 
        }
    }
}
