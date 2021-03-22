using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    class Freelancer : Person
    {
        public Freelancer(string name, List<TimeRecord> timeRecord) : base(name, timeRecord)
        {
            
        }
    }
}
