using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace CalculatorWFA
{
    public partial class CalcForm : Form
    {
        public MathActions Calculator { get; set; }
        public List<List<string>> History { get; set; }
        public bool CheckAnswer { get; set; }
        public HistoryForm HF { get; set; }
        public event EventHandler ClearForm;

        public CalcForm()
        {
            InitializeComponent();
            Calculator = new MathActions();
            History = new List<List<string>>();
            ClearForm += ClearAllBtn_Click;
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (InputNumbLbl.Text.Length == 0)
            {
                InputNumbLbl.Text = "0,";
            }
            else
            {
                double answer;
                InputNumbLbl.Text += ",";
                if (!double.TryParse(InputNumbLbl.Text, out answer)) InputNumbLbl.Text = InputNumbLbl.Text.Remove(InputNumbLbl.Text.Length - 1, 1);
            }
        }

        #region Numbers
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '0';
            }
            else
            {
                InputNumbLbl.Text = 0.ToString();
                CheckAnswer = false;
            }

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '1';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 1.ToString();
                CheckAnswer = false;
            }

        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '2';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 2.ToString();
                CheckAnswer = false;
            }

        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '3';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 3.ToString();
                CheckAnswer = false;
            }

        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '4';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 4.ToString();
                CheckAnswer = false;
            }

        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '5';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 5.ToString();
                CheckAnswer = false;
            }

        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '6';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 6.ToString();
                CheckAnswer = false;
            }

        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '7';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 7.ToString();
                CheckAnswer = false;
            }

        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '8';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 8.ToString();
                CheckAnswer = false;
            }

        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer)
            {
                InputNumbLbl.Text += '9';
            }
            else
            {
                if (Calculator.Action == ACTIONS.NOACTION)
                {
                    ClearForm.Invoke(sender, e);
                }
                InputNumbLbl.Text = 9.ToString();
                CheckAnswer = false;
            }

        }
        #endregion

        #region ActionsWithTwoNumbers

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculator.NumberA == null)
                {
                    Calculator.NumberA = Convert.ToDouble(InputNumbLbl.Text);
                    if (!CheckAnswer) Calculator.HistoryShow.Add(InputNumbLbl.Text);
                    else CheckAnswer = false;
                    Calculator.HistoryShow.Add(" + ");
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = string.Empty;
                    Calculator.Action = ACTIONS.PLUS;
                }
                else
                {
                    Calculator.NumberB = Convert.ToDouble(InputNumbLbl.Text);
                    Calculator.HistoryShow.Add(InputNumbLbl.Text); Calculator.HistoryShow.Add(" + ");
                    Calculator.Equal();
                    Calculator.Action = ACTIONS.PLUS;
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = Calculator.NumberA.ToString();
                    CheckAnswer = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculator.NumberA == null)
                {
                    Calculator.NumberA = Convert.ToDouble(InputNumbLbl.Text);
                    if (!CheckAnswer) Calculator.HistoryShow.Add(InputNumbLbl.Text);
                    else CheckAnswer = false;
                    Calculator.HistoryShow.Add(" - ");
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = string.Empty;
                    Calculator.Action = ACTIONS.MINUS;
                }
                else
                {
                    Calculator.NumberB = Convert.ToDouble(InputNumbLbl.Text);
                    Calculator.HistoryShow.Add(InputNumbLbl.Text); Calculator.HistoryShow.Add(" - ");
                    Calculator.Equal();
                    Calculator.Action = ACTIONS.MINUS;
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = Calculator.NumberA.ToString();
                    CheckAnswer = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculator.NumberA == null)
                {
                    Calculator.NumberA = Convert.ToDouble(InputNumbLbl.Text);
                    if (!CheckAnswer) Calculator.HistoryShow.Add(InputNumbLbl.Text);
                    else CheckAnswer = false;
                    Calculator.HistoryShow.Add(" / ");
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = string.Empty;
                    Calculator.Action = ACTIONS.DIVIDE;
                }
                else
                {
                    Calculator.NumberB = Convert.ToDouble(InputNumbLbl.Text);
                    Calculator.HistoryShow.Add(InputNumbLbl.Text); Calculator.HistoryShow.Add(" / ");
                    Calculator.Equal();
                    Calculator.Action = ACTIONS.DIVIDE;
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = Calculator.NumberA.ToString();
                    CheckAnswer = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculator.NumberA == null)
                {
                    Calculator.NumberA = Convert.ToDouble(InputNumbLbl.Text);
                    if (!CheckAnswer) Calculator.HistoryShow.Add(InputNumbLbl.Text);
                    else CheckAnswer = false;
                    Calculator.HistoryShow.Add(" * ");
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = string.Empty;
                    Calculator.Action = ACTIONS.MULTIPLY;
                }
                else
                {
                    Calculator.NumberB = Convert.ToDouble(InputNumbLbl.Text);
                    Calculator.HistoryShow.Add(InputNumbLbl.Text); Calculator.HistoryShow.Add(" * ");
                    Calculator.Equal();
                    Calculator.Action = ACTIONS.MULTIPLY;
                    InputLbl.Text = Calculator.UpdateHistoryLog();
                    InputNumbLbl.Text = Calculator.NumberA.ToString();
                    CheckAnswer = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        #endregion

        #region ClearInputs

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            CheckAnswer = false;
            Calculator = new MathActions();
            InputNumbLbl.Text = string.Empty;
            InputLbl.Text = string.Empty;
        }

        private void ClearInputBtn_Click(object sender, EventArgs e)
        {
            CheckAnswer = false;
            InputNumbLbl.Text = string.Empty;
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            if (InputNumbLbl.Text.Length != 0) InputNumbLbl.Text = InputNumbLbl.Text.Remove(0, 1);
        }

        #endregion

        #region ActionsWithOneNumber

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (Math.Sign(Convert.ToDouble(InputNumbLbl.Text)) == 1)
            {
                InputNumbLbl.Text = '-' + InputNumbLbl.Text;
            }
            else
            {
                InputNumbLbl.Text = InputNumbLbl.Text.Remove(0, 1);
            }
        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpValue = Math.Sqrt(Convert.ToDouble(InputNumbLbl.Text));
                Calculator.HistoryShow.Add(string.Format("Sqrt({0})", InputNumbLbl.Text));
                InputLbl.Text = Calculator.UpdateHistoryLog();
                InputNumbLbl.Text = tmpValue.ToString();
                CheckAnswer = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void SqrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpValue = Math.Sqrt(Convert.ToDouble(InputNumbLbl.Text));
                Calculator.HistoryShow.Add(string.Format("Sqrt({0})", InputNumbLbl.Text));
                InputLbl.Text = Calculator.UpdateHistoryLog();
                InputNumbLbl.Text = tmpValue.ToString();
                CheckAnswer = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void SqrMinusOneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpValue = 1F / Convert.ToDouble(InputNumbLbl.Text);
                Calculator.HistoryShow.Add(string.Format("1/({0})", InputNumbLbl.Text));
                InputLbl.Text = Calculator.UpdateHistoryLog();
                InputNumbLbl.Text = tmpValue.ToString();
                CheckAnswer = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpValue;
                if (Calculator.NumberA == null)
                {
                    tmpValue = 0F * Convert.ToDouble(InputNumbLbl.Text) / 100F;
                }
                else
                {
                    tmpValue = (double)Calculator.NumberA * Convert.ToDouble(InputNumbLbl.Text) / 100F;
                }
                Calculator.HistoryShow.Add(string.Format("{0}%", InputNumbLbl.Text));
                InputLbl.Text = Calculator.UpdateHistoryLog();
                InputNumbLbl.Text = tmpValue.ToString();
                CheckAnswer = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "NullReferenceException");
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели никаких значений", "FormatException");
            }
        }

        #endregion

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            double tmpValue = Convert.ToDouble(InputNumbLbl.Text);
            try
            {
                Calculator.NumberB = Convert.ToDouble(InputNumbLbl.Text);
                if (!CheckAnswer) Calculator.HistoryShow.Add(InputNumbLbl.Text);
                else CheckAnswer = false;
                Calculator.Equal();
                double savedData = (double)Calculator.NumberA;
                InputLbl.Text = Calculator.UpdateHistoryLog();
                Calculator.HistoryShow.Add(" = ");
                Calculator.HistoryShow.Add(Calculator.NumberA.ToString());
                History.Add(Calculator.HistoryShow);
                ClearForm.Invoke(sender, e);
                InputNumbLbl.Text = savedData.ToString();
                CheckAnswer = true;
            }
            catch (InvalidOperationException)
            {
                ClearForm.Invoke(sender, e);
                InputNumbLbl.Text = tmpValue.ToString();
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HF = new HistoryForm(this);
            HF.Show();
        }

    }
}
