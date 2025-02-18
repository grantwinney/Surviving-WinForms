using System.Collections.Generic;

namespace MVPExample.Interfaces
{
    public interface ICalcModel
    {
        decimal Total { get; set; }
        decimal RunningTotal { get; set; }
        void CalculateTotal(List<decimal> numbers);
        void ResetTotal();
    }
}
