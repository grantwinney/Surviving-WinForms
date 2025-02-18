using MVPExample.Interfaces;
using System;
using System.Collections.Generic;

namespace MVPExample.Presenters
{
    public class CalcPresenter
    {
        readonly ICalcView calcView;
        readonly ICalcModel calcModel;

        public CalcPresenter(ICalcView view, ICalcModel model)
        {
            calcView = view;
            calcModel = model;

            calcView.Add += (s, e) => Add();
            calcView.Reset += (s, e) => Reset();

            calcView.Show();
        }

        public void Add()
        {
            calcModel.CalculateTotal(new List<string> { calcView.Value1, calcView.Value2, calcView.Value3 }.ConvertAll(TryGetNumber));

            calcView.Total = Convert.ToString(calcModel.Total);
            calcView.RunningTotal = Convert.ToString(calcModel.RunningTotal);
        }

        public void Reset()
        {
            calcModel.ResetTotal();

            calcView.Value1 = calcView.Value2 = calcView.Value3 = calcView.Total = calcView.RunningTotal = "";
            calcView.SetFocusOnFirstTextBox();
        }

        public decimal TryGetNumber(string input)
        {
            return decimal.TryParse(input, out decimal res) ? res : 0;
        }
    }
}
