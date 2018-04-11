using System;
using Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeworkTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CanCreateCar()
        {
            var car = new Car();
            Assert.IsNotNull(car);
        }
    }
}
