using System.Collections.Generic;

namespace MVPExample.Interfaces
{
    public interface ICalcModel
    {
        decimal Total { get; }
        decimal RunningTotal { get; }
        void CalculateTotal(List<decimal> numbers);
        void ResetTotal();
    }
}
