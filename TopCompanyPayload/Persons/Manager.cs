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
            }
        }
    }
}
