using Microsoft.Extensions.Time.Testing;
using NUnit.Framework;
using System;
using TimeAbstraction;

namespace TimeAbstractionTests
{
    [TestFixture]
    public class DiscountTests
    {
        private FakeTimeProvider fakeTimeProvider;
        private DiscountLogic discountLogic;

        [SetUp]
        public void Setup()
        {
            fakeTimeProvider = new FakeTimeProvider();
            fakeTimeProvider.SetLocalTimeZone(TimeZoneInfo.Utc);

            discountLogic = new DiscountLogic(fakeTimeProvider);
        }

        [Test]
        public void GivenSummer_WhenWeekend_ThenNoDiscount()
        {
            fakeTimeProvider.SetUtcNow(DateTimeOffset.Parse("7/27/2024"));

            Assert.That(discountLogic.DailyDiscount, Is.EqualTo(0));
            Assert.That(discountLogic.GetDiscountPrice(5), Is.EqualTo(5m));
        }

        [Test]
        public void GivenSummer_WhenWeekday_ThenTinyDiscount()
        {
            fakeTimeProvider.SetUtcNow(DateTimeOffset.Parse("7/25/2024"));

            Assert.That(discountLogic.DailyDiscount, Is.EqualTo(10));
            Assert.That(discountLogic.GetDiscountPrice(5), Is.EqualTo(4.5m));
        }

        [Test]
        public void GivenWinter_WhenWeekday_ThenLargeDiscount()
        {
            fakeTimeProvider.SetUtcNow(DateTimeOffset.Parse("2/2/2024"));

            Assert.That(discountLogic.DailyDiscount, Is.EqualTo(40));
            Assert.That(discountLogic.GetDiscountPrice(8), Is.EqualTo(4.8m));
        }

        [Test]
        public void GivenFall_WhenWeekend_ThenTinyDiscount()
        {
            fakeTimeProvider.SetUtcNow(DateTimeOffset.Parse("9/28/2024"));

            Assert.That(discountLogic.DailyDiscount, Is.EqualTo(10));
            Assert.That(discountLogic.GetDiscountPrice(15), Is.EqualTo(13.5m));
        }
    }
}