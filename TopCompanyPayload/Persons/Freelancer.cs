using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    class Freelancer : Person
    {
        public decimal TotalPay {get; }

        public Freelancer(string name, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
            decimal payPerHours = 1000;
            decimal totalPay = 0; 

            foreach(var timeRecord in timeRecords)
            {
                totalPay += payPerHours * timeRecord.Hours; 
            }

            TotalPay = totalPay; 
        }
    }
}
