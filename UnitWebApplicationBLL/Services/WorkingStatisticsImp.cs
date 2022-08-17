using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplicationBLL.Services
{
    public class WorkingStatisticsImp:WorkingStatistics
    {
        public int WorkingHours { get; set; }
        public int WorkingMinutes { get; set; }
        public decimal HourSalary { get; set; }
        public decimal MonthSalary { get; set; }
        public bool PayHourly { get; set; }
    }
}
