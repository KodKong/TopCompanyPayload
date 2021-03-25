using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Emloyee : Staff
    {

        public decimal TotalPay { get; }

        public Emloyee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {
            decimal payPerHour = MonthSalary / Settings.WorkHoursInDay;
            decimal totalPay = 0; 

            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Settings.WorkHoursInDay)
                {
                    totalPay += payPerHour * timeRecord.Hours; 
                }
                else // перерработка
                {
                    totalPay += (payPerHour * timeRecord.Hours) * 2; 
                }
            }

            TotalPay = totalPay; 
        }
    }
}
