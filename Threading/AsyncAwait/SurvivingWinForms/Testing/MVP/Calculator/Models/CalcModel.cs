using System.Collections.Generic;
using System.Linq;
using SurvivingWinForms.Testing.MVP.Calculator.Interfaces;

namespace SurvivingWinForms.Testing.MVP.Calculator.Models
{
    public class CalcModel : ICalcModel
    {
        public decimal Total { get; private set; }
        public decimal RunningTotal { get; private set; }

        public void CalculateTotal(List<decimal> numbers)
        {
            Total = numbers.Sum();
            RunningTotal += Total;
        }
    }
}
