using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplicationBLL.Services
{
    public class DbGatewaySpy:IDbGetway
    {
        private WorkingStatisticsImp _ws;
        public int Id { get; private set; }
        public WorkingStatisticsImp GetWorkingStatistics(int id)
        {
            Id = id;
            return _ws;
        }
        public void SetWorkingStatistics(WorkingStatisticsImp ws)
        {
            _ws = ws;
        }
    }
}
