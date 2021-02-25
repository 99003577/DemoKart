using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void Payment_method()
        {
            double expected = 103;
            var PaymentObj = new Payment();
            double actual = PaymentObj.Payment_method(100);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Tax()
        {
            double expected = 118;
            var PaymentObj = new Payment();
            double actual = PaymentObj.Tax(1,100,1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Tax2()
        {
            double expected = 107;
            var PaymentObj = new Payment();
            double actual = PaymentObj.Tax(2, 100, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Tax3()
        {
            double expected = 104;
            var PaymentObj = new Payment();
            double actual = PaymentObj.Tax(3, 100, 1);
            Assert.AreEqual(expected, actual);
        }

    }
}