using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Emloyee : Staff
    {
        public Emloyee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {
          
        }
    }
}
