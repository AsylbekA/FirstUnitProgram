using FirstUnitProgram;
using NUnit.Framework;

namespace FirstUnitProgramTest
{
    class CalculaterTest
    {
        private Calculator _calculater;
        [SetUp]
        public void SetUp()=> _calculater = new Calculator();  
        
        [TearDown]
        public void Teardown()=> _calculater = null;
        
        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [Test]
        public void AddWithInc_2Plus3Inc1_Returned6()
        {
            // arrange 
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = _calculater.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
        //refactoring
        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [Test]
        [TestCase(7, 2, 10)]
        [TestCase(6, 5, 12)]
        public void AddWithInc_7Plus2Inc1_Returned10(int arg1, int arg2, int expected)
        {
            // act
            double result = _calculater.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Div_5div3_Returned1()
        {
            // arrange 
            double arg1 = 6;
            double arg2 = 3;
            double expected = 2;
            // act
            double result = _calculater.Div(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [Test]
        public void AddWithInc_6Plus3Inc1_Returned10()
        {
            // arrange 
            double arg1 = 6;
            double arg2 = 3;
            double expected = 10;
            // act
            double result = _calculater.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }



      
    }
}
