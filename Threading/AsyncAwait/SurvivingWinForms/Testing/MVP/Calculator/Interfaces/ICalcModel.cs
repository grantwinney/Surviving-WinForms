using System.Collections.Generic;

namespace SurvivingWinForms.Testing.MVP.Calculator.Interfaces
{
    public interface ICalcModel
    {
        decimal Total { get; }
        decimal RunningTotal { get; }
        void CalculateTotal(List<decimal> numbers);
    }
}
