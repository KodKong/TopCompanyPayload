using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCompanyPayload
{
    public class Person
    {
        public string Name { get; }
        public List<TimeRecord> TimeRecord { get; set; }

        public Person (string name, List<TimeRecord> timeRecord)
        {
            Name = name;
            TimeRecord = timeRecord; 
        }
    }
}
