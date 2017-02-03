using System;
using System.Windows.Forms;

namespace CalculatorWFA
{
    public partial class HistoryForm : Form
    {
        private CalcForm Cf { get; set; }

        public HistoryForm(CalcForm cf)
        {
            InitializeComponent();
            Cf = cf;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            HistoryLbl.Text = string.Empty;
            Cf.Enabled = false;
            foreach (var item in Cf.History)
            {
                foreach (var historyElement in item)
                {
                    HistoryLbl.Text += historyElement;
                }
                HistoryLbl.Text += Environment.NewLine;
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Cf.Enabled = true;
            Close();
        }

        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cf.Enabled = true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HistoryLbl.Text = @"Журнала ещё нет";
            Cf.Calculator.HistoryShow.Clear();
            Cf.History.Clear();
        }
    }
}
