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
            /* List<TimeRecord> list = new List<TimeRecord>();
            DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            list.Add(new TimeRecord(date1, "Lexa", 8, "ничего не делал"));

            Manager manager = new Manager("Lexa", list);

            Menu.WriteWorker(manager); */

           
               Console.WriteLine("Hello, write your name");
               string name = Console.ReadLine();
               if(Menu.Authorization(name))
               {
                    Console.WriteLine("Great"); 
               }else
               {
                    Console.WriteLine("Error!"); 
               }
                
            


        }
    }
}
