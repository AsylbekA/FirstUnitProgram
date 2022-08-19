using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplicationBLL.Services
{
    public class CustomerImp : ICustomer
    {
        #region DI (Внедрение зависимости) 1-способ через конструктор
        //DI (Внедрение зависимости) 1-способ через конструктор
        private readonly ILoggers _logger;
        private readonly IDbGetway _dbGetway;
        public CustomerImp(ILoggers logger, IDbGetway dbGetway)
        {
            _logger = logger;
            _dbGetway = dbGetway;
        }
        #endregion

        #region DI (Внедрение зависимости) 2-способ через свойства
        ////DI (Внедрение зависимости) 2-способ через свойства
        //public IDbGetway DbGetway { get;set; }
        //public ILoggers Loggers { get; set; }
        #endregion

        /// <summary>
        /// Рассчитать заработную плату
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public decimal CalculateWage(int id)
        {
            WorkingStatisticsImp ws = _dbGetway.GetWorkingStatistics(id);//  (Внедрение зависимости) 1-способ через конструктор
                                                                         // WorkingStatisticsImp ws2 = DbGetway.GetWorkingStatistics(id); // (Внедрение зависимости) 2-способ через свойства
            decimal wage;
            if (ws.PayHourly)
                wage = ws.WorkingHours * ws.HourSalary;
            else
                wage = ws.MonthSalary;

            _logger.Info($"Customer ID={id}, Wage:{wage}");//  (Внедрение зависимости) 1-способ через конструктор
                                                           // Loggers.Info($"Customer ID={id}, Wage:{wage}");// (Внедрение зависимости) 2-способ через свойства
            return wage;
        }
    }
}
