using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SurvivingWinForms.Testing.MVP.Calculator.Models;

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
        public void AddingNumbersTwiceRetainsLastOnly()
        {
            model.CalculateTotal(new List<decimal> { 1, 2, 3 });
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
    }
}
