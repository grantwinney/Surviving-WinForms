using System;

namespace MVPExample.Interfaces
{
    public interface ICalcView
    {
        event EventHandler Add;
        event EventHandler Reset;
        string Value1 { get; set; }
        string Value2 { get; set; }
        string Value3 { get; set; }
        string Total { set; }
        string RunningTotal { set; }
        void SetFocusOnFirstTextBox();
        void Show();
    }
}