using FirstUnitProgram;
using NUnit.Framework;

namespace FirstUnitProgramTest
{
    class CalculaterTest
    {
        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [Test]
        public void AddWithInc_2Plus3Inc1_Returned6()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = calc.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Div_5div3_Returned1()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 6;
            double arg2 = 3;
            double expected = 2;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
    }
}
