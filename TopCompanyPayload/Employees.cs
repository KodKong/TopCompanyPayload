using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{

    abstract class Employeees
    {
        public string position;
        public string name;
        public int hours;
        public decimal paymentPerHour;
        public decimal salary;

        public Employeees(string position, string name, int hours, decimal paymentPerHour, decimal salary)
        {
            this.position = position; 
            this.name = name;
            this.hours = hours;
            this.paymentPerHour = paymentPerHour;
            this.salary = salary; 
        }

        public Employeees worker { get; set; }


        public void ShowReport(Employeees a)
        {
        
        }
    }


    class Director : Employeees
    {
        public Director(string position, string name, int hours, decimal paymentPerHour, decimal salary) 
            : base (position, name, hours, paymentPerHour, salary)
        {
           salary = 200000; 
        }

        int index = 0;
        string[] data; 
        public void GetListEmp()
        {
            string path = @"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников.txt";
            using (StreamReader str = new StreamReader(path, true))
            {
                string line;
                while ((line = str.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    data[index] = line; 
                    index++; 
                }
            }
        }

        public void AddHour(Employeees worker)
        {
            Console.WriteLine("Выберете сотрудника");
            int ind = int.Parse(Console.ReadLine());
            string trueWorker = "ничего"; 
            if (ind > index || ind < 0)
            {
                Console.WriteLine("Неправильный номер сотрудника");
                AddHour(worker); 
            }
            for(int i = 0; i < data.Length; i++)
            {
                if (ind == (int)data[i][0])
                {
                    trueWorker = data[i];
                    break; 
                }
            }

            Console.WriteLine(trueWorker); 
        }

        public void AddInDataBase(Employeees worker)
        {
            string path = @"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников.txt";
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine($"{++index}. Имя: {worker.name} --- Позиция: {worker.position} --- Зарплата: {worker.salary}");
            }
                
        }
    }
}
