using MVPExample.Interfaces;
using System;
using System.Collections.Generic;

namespace MVPExample.Presenters
{
    public class CalcPresenter
    {
        readonly ICalcView view;
        readonly ICalcModel model;

        public CalcPresenter(ICalcView view, ICalcModel model)
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
            model.ResetTotal();

            view.Value1 = view.Value2 = view.Value3 = view.Total = view.RunningTotal = "";
        }

        public decimal TryGetNumber(string input)
        {
            return decimal.TryParse(input, out decimal res) ? res : 0;
        }
    }
}
