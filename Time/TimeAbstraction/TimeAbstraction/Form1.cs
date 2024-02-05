using System;
using System.Windows.Forms;

namespace TimeAbstraction
{
    public partial class Form1 : Form
    {
        readonly TimeProvider tp;

        public Form1()
        {
            InitializeComponent();

            tp = Services.Get<TimeProvider>();

            var timer = tp.CreateTimer(
                callback: (state) => Invoke(new Action(() =>
                    tslCurrentTimeUpdate.Text = tp.GetLocalNow().ToString("T"))),
                state: null,
                dueTime: TimeSpan.Zero,
                period: TimeSpan.FromSeconds(1));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            GetTime();

            var dl = Services.Get<IDiscountLogic>();
            lblDiscount.Text =
                $"The discount for {tp.GetLocalNow().ToString("dddd, MMM d")} is {dl.DailyDiscount}%. " +
                $"A $5.00 icecream costs ${dl.GetDiscountPrice(5):N2} today.";
        }

        private void btnRefreshTime_Click(object sender, EventArgs e)
        {
            GetTime();
        }

        private void GetTime()
        {
            tslCurrentTimeOnce.Text = tp.GetLocalNow().ToString("T");
        }
    }
}
