using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using UnitWebApplicationBLL.Intercafes;
using UnitWebApplicationBLL.Services;

namespace UnitWebApplicationBLLTest.Services
{
    [TestFixture]
    public class CustomerImpTestWithMockingFramework
    {
        [Test]
        public void CalculateWage_HourlyPayed_ReturnsCorrectWage()
        {
            var gateway = Substitute.For<IDbGetway>();
            var workingStatistics = new WorkingStatisticsImp() { PayHourly = true, HourSalary = 100, WorkingHours = 10 };
            const int anyId = 1;

            gateway.GetWorkingStatistics(anyId).ReturnsForAnyArgs(workingStatistics);

            const decimal expectedWage = 100 * 10;
            var sut = new CustomerImp(Substitute.For<ILoggers>(), gateway);

            decimal actual = sut.CalculateWage(anyId);

            Assert.That(actual, Is.EqualTo(expectedWage).Within(0.1));
        }

        [Test]
        public void CalculateWage_PassesCorrecId()
        {
            const int anyId = 1;
            var gateway = Substitute.For<IDbGetway>();
            gateway.GetWorkingStatistics(anyId).ReturnsForAnyArgs(new WorkingStatisticsImp());

            var sut = new CustomerImp(Substitute.For<ILoggers>(), gateway);
            sut.CalculateWage(anyId);
            gateway.Received().GetWorkingStatistics(anyId);
        }
    }

    [TestFixture]
    public class CustomerImpTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateWage_HourlyPayed_ReturnsCorrectWage()
        {
            // arrange 
            DbGetwayImp gateway = new();
            const decimal expectedWage = 100 * 10;
            var sut = new CustomerImp(new LoggerImp(), gateway);
            const int anyId = 1;
            // act
            gateway.SetWorkingStatistics(new WorkingStatisticsImp()
            { PayHourly = true, HourSalary = 100, WorkingHours = 10 });
            decimal actual = sut.CalculateWage(anyId);
            // assert  
            Assert.That(actual, Is.EqualTo(expectedWage).Within(0.1));
        }
        public void CalculateWage_PassesCorrecId()
        {
            const int id = 1;
            var gateway = new DbGatewaySpy();
            var sut = new CustomerImp(new LoggerImp(), gateway);
            sut.CalculateWage(id);
            Assert.That(1, Is.EqualTo(gateway.Id));
        }
    }
}
