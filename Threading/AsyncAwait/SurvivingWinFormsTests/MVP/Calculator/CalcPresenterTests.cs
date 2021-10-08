using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SurvivingWinForms.Testing.MVP.Calculator.Interfaces;
using SurvivingWinForms.Testing.MVP.Calculator.Presenters;

namespace MVP.Calculator
{
    [TestFixture]
    public class CalcPresenterTests
    {
        Mock<ICalcView> mockView;
        Mock<ICalcModel> mockModel;
        CalcPresenter presenter;

        [SetUp]
        public void Setup()
        {
            mockModel = new Mock<ICalcModel>();
            mockView = new Mock<ICalcView>();
            presenter = new CalcPresenter(mockView.Object, mockModel.Object);
        }

        [Test]
        public void AddTest()
        {
            mockView.SetupGet(x => x.Value1).Returns("10");
            mockView.SetupGet(x => x.Value2).Returns("20");
            mockView.SetupGet(x => x.Value3).Returns("30");
            mockModel.SetupGet(x => x.Total).Returns(60m);
            mockModel.SetupGet(x => x.RunningTotal).Returns(100m);

            presenter.Add(null, null);

            mockModel.Verify(x => x.CalculateTotal(It.IsAny<List<decimal>>()), Times.Once);
            mockView.VerifySet(x => x.Total = "60", Times.Once);
            mockView.VerifySet(x => x.RunningTotal = "100", Times.Once);
        }

        [Test]
        public void ResetTest()
        {
            presenter.Reset(null, null);

            mockView.VerifySet(x => x.Value1 = "", Times.Once);
            mockView.VerifySet(x => x.Value2 = "", Times.Once);
            mockView.VerifySet(x => x.Value3 = "", Times.Once);
            mockView.VerifySet(x => x.Total = "", Times.Once);
            mockView.VerifySet(x => x.RunningTotal = It.IsAny<string>(), Times.Never);
        }

        [Test]
        [TestCase("3", 3)]
        [TestCase("-3.22", -3.22)]
        [TestCase("0", 0)]
        [TestCase("", 0)]
        [TestCase("bad input!!", 0)]
        public void TryGetNumberReturnsExpectedValue(string input, decimal output)
        {
            Assert.AreEqual(output, presenter.TryGetNumber(input));
        }
    }
}