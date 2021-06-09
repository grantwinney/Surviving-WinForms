using System;
using System.Collections.Generic;
using SurvivingWinForms.Testing.MVP.Calculator.Interfaces;

namespace SurvivingWinForms.Testing.MVP.Calculator.Presenters
{
    public class CalcPresenter
    {
        readonly ICalcView view;
        readonly ICalcModel model;

        public CalcPresenter(ICalcView view = null, ICalcModel model = null)
        {
            this.view = view;
            this.model = model;
            this.view.Add += Add;
            this.view.Reset += Reset;
            this.view.Show();
        }

        public void Add(object sender, EventArgs e)
        {
            model.CalculateTotal(new List<string> { view.Value1, view.Value2, view.Value3 }.ConvertAll(TryGetNumber));

            view.Total = Convert.ToString(model.Total);
            view.RunningTotal = Convert.ToString(model.RunningTotal);
        }

        public void Reset(object sender, EventArgs e)
        {
            view.Value1 = view.Value2 = view.Value3 = view.Total = "";
        }

        public decimal TryGetNumber(string input)
        {
            return decimal.TryParse(input, out decimal res) ? res : 0;
        }
    }
}
