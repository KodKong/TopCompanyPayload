using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TopCompanyPayload
{   

    public static class Menu
    {

        static List<Person> GetList()
        {
            string jsonString = File.ReadAllText(@"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников");
            List<Person> employees = JsonSerializer.Deserialize<List<Person>>(jsonString);
            return employees; 
        }


        public static bool Authorization (string name)
        {
            List<Person> employees = GetList(); 
            foreach(Person item in employees)
            {
                if (name == item.Name)
                {
                    return true; 
                }
            }
            return false; 
        }

        public static void WriteWorker (Person worker)
        {
            string jsonString = JsonSerializer.Serialize<Person>(worker);
            string path = @"C:\Users\ADMIN\Desktop\Зарплаты\Список_Сотрудников.txt";
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine(jsonString);
        }
    }
}
