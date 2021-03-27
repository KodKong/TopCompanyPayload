using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Manager : Staff
    {
        public decimal MonthBonus => 20000;
        public decimal TotalPay { get; }
        public Manager (string name, List<TimeRecord> timeRecords) : base (name, 200000, timeRecords)
        {

            decimal payPerHour = MonthSalary / Settings.WorkHoursInMonth;
            decimal totalPay = 0;
            decimal bonusPerDay = (MonthBonus / Settings.WorkHoursInMonth) * Settings.WorkHoursInDay; 

            foreach (var timeRecord in timeRecords)
            {

                if (timeRecord.Hours <= Settings.WorkHoursInDay)
                {
                    totalPay += payPerHour * timeRecord.Hours; 
                }
                else // переработка
                {
                    totalPay += Settings.WorkHoursInDay * payPerHour + bonusPerDay; 
                }

                TotalPay = totalPay; 
            }
        }

        public Manager AddManager (string name)
        {
            List<TimeRecord> startTime = new List<TimeRecord>();
            Manager newWorker = new Manager(name, startTime);
            return newWorker; 
        }

        public Emloyee AddEmloyee(string name)
        {
            List<TimeRecord> startTime = new List<TimeRecord>();
            Emloyee newWorker = new Emloyee(name, startTime);
            return newWorker;
        }

        public Freelancer AddFreelancer(string name)
        {
            List<TimeRecord> startTime = new List<TimeRecord>();
            Freelancer newWorker = new Freelancer(name, startTime);
            return newWorker;
        }

        public void AddTimeWork(Person worker, DateTime startTime, byte hours, string message)
        {
            TimeRecord obj = new TimeRecord(startTime, worker.Name, hours, message);
            worker.TimeRecord.Add(obj); 
        }
    }
}
