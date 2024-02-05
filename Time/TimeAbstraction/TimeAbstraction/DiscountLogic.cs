using System;

namespace TimeAbstraction
{
    public class DiscountLogic : IDiscountLogic
    {
        readonly TimeProvider _timeProvider;

        public DiscountLogic(TimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public decimal DailyDiscount
        {
            get
            {
                var now = _timeProvider.GetLocalNow();
                var discountPercent = 0;

                if (now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
                    discountPercent += 10;

                discountPercent +=
                    now.Month >= 11 || now.Month <= 2 ? 30 :      // Nov, Dec, Jan, Feb
                    now.Month >= 3 && now.Month <= 5 ? 20 :       // Mar, Apr, May
                    now.Month >= 9 && now.Month <= 10 ? 10 : 0;   // Sep, Oct

                return discountPercent;
            }
        }

        public decimal GetDiscountPrice(decimal originalPrice)
        {
            return originalPrice * ((100 - DailyDiscount) / 100);
        }
    }

    public interface IDiscountLogic
    {
        decimal DailyDiscount { get; }
        decimal GetDiscountPrice(decimal originalPrice);
    }
}
