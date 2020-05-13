using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarlaMulligan_S00186667; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasingPrice()
        {

            //Arrange 
            Phone increasing = new Phone();
            decimal price = 50; 


            //Act
            increasing.IncreasePrice(25);


            //Assert
            Assert.AreEqual(price, increasing.Price); 

        }
    }
}
