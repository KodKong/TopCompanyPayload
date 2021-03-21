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
            decimal paymentPerHour = 0;
            decimal salary = 0; 
           Director st1 = new Director(position, name, hours, paymentPerHour, salary);
            st1.AddInDataBase(st1);
            Console.ReadLine();
            st1.GetListEmp();
            st1.AddHour(st1); 
        }
    }
}
