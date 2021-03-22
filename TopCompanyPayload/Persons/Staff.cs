using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Staff : Person
    {
        public decimal MonthSalary { get;  }

        public Staff(string name, decimal monthSalary, List<TimeRecord> timeRecord) : base(name, timeRecord)
        {
            MonthSalary = monthSalary; 
        }
    }
}
