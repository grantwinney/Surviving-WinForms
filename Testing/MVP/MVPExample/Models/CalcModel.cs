using System.Collections.Generic;
using System.Linq;
using MVPExample.Interfaces;

namespace MVPExample.Models
{
    public class CalcModel : ICalcModel
    {
        public decimal Total { get; set; }
        public decimal RunningTotal { get; set; }

        public void CalculateTotal(List<decimal> numbers)
        {
            Total = numbers.Sum();
            RunningTotal += Total;
        }

        public void ResetTotal()
        {
            Total = 0;
            RunningTotal = 0;
        }
    }
}
