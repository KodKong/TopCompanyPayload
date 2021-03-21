using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Employees
    { 
        string name; 
        string position;
        int hours;
        decimal moneyOnHour; 

        public Employees (string position, string name, int hours, decimal moneyOnHour)
        {
            this.position = position;
            this.hours = hours;
            this.moneyOnHour = moneyOnHour;
            this.name = name; 
        }

        public void GetListEmp ()
        {
            string path = @"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников.txt";
            using (StreamReader str = new StreamReader(path, true))
            {
                string line;
                while ((line = str.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void AddHour (Employees em)
        {
            em.GetListEmp(); 

        }

        public void AddInDataBase (Employees a)
        {
            string path = @"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников.txt";
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine($"{a.name} --- {a.position}"); 
        }
    }
}
