using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplicationBLL.Services
{
    public class DbGetwayImp : IDbGetway
    {
        private WorkingStatisticsImp _ws;
        public WorkingStatisticsImp GetWorkingStatistics(int id)
        {
            return _ws;
        }
        public void SetWorkingStatistics(WorkingStatisticsImp ws)
        {
            _ws = ws;
        }
    }
}
