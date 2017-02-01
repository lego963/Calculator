using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
    public partial class HistoryForm : Form
    {
        public CalcForm CF { get; set; }

        public HistoryForm(CalcForm cf)
        {
            InitializeComponent();
            CF = cf;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            HistoryLbl.Text = string.Empty;
            CF.Enabled = false;
            foreach (var item in CF.History)
            {
                foreach (var historyElement in item)
                {
                    HistoryLbl.Text += historyElement;
                }
                HistoryLbl.Text += "\r\n";
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            CF.Enabled = true;
            Close();
        }
    }
}
