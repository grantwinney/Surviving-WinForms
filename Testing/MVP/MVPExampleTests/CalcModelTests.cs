using System;
using System.Collections.Generic;
using System.Linq;
using MVPExample.Models;
using NUnit.Framework;

namespace MVP.Calculator
{
    [TestFixture]
    public class CalcModelTests
    {
        CalcModel model;

        [SetUp]
        public void Setup()
        {
            model = new CalcModel();
        }

        [Test]
        [TestCase(-13, -1, -1, -1, -10)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(15, 1, 2, 3, 4, 5)]
        public void AddingNumbersGeneratesExpectedTotal(decimal expectedTotal, params int[] inputs)
        {
            model.CalculateTotal(inputs.Select(Convert.ToDecimal).ToList());

            Assert.AreEqual(expectedTotal, model.Total);
        }

        [Test]
        public void AddingNumbersTwiceRetainsLastTotalOnly()
        {
            model.CalculateTotal(new List<decimal> { 1, 2, 3 });
            Assert.AreEqual(6, model.RunningTotal);
           
            model.CalculateTotal(new List<decimal> { 10, 20, 30 });
            Assert.AreEqual(60, model.Total);
        }

        [Test]
        public void AddingNumbersTwiceIncreasesRunningTotal()
        {
            model.CalculateTotal(new List<decimal> { 1, 2, 3 });
            Assert.AreEqual(6, model.RunningTotal);

            model.CalculateTotal(new List<decimal> { 10, 20, 30 });
            Assert.AreEqual(66, model.RunningTotal);
        }

        [Test]
        public void ResetNumbersToZeroWorksAsExpected()
        {
            model.CalculateTotal(new List<decimal> { 1, 2, 3 });
            Assert.AreEqual(6, model.Total);
            Assert.AreEqual(6, model.RunningTotal);

            model.ResetTotal();
            Assert.AreEqual(0, model.Total);
            Assert.AreEqual(0, model.RunningTotal);
        }
    }
}
