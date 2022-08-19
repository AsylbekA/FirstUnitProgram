using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitWebApplicationBLL.Intercafes
{
    internal interface WorkingStatistics
    {
         int WorkingHours { get; set; }
         int WorkingMinutes { get; set; }
         decimal HourSalary { get; set; }
         bool PayHourly { get; set; }
    }
}
