using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitWebApplicationBLL.Services;

namespace UnitWebApplicationBLL.Intercafes
{
    public interface IDbGetway
    {
        WorkingStatisticsImp GetWorkingStatistics(int id);
    }
}
