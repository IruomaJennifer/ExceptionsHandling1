using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment1
{
    public class Worker
    {
        public Worker(decimal wage)
        {
            Wage= wage;
            HoursWorkedPerDay = new int[7];

        }
        public string Name { get; set; }
        public decimal Wage { get; set; }
        public int[] HoursWorkedPerDay { get; set; }

    }
}
