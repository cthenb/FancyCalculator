using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorGUI : Form
    {
        private decimal? _totalValue;
        private CalculationTypes? _calculationType;

        public CalculatorGUI()
        {
            InitializeComponent();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _totalValue = InputField.Value;
            _calculationType = CalculationTypes.Divide;
            AfterClickHandler();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _totalValue = InputField.Value;
            _calculationType = CalculationTypes.Multiply;
            AfterClickHandler();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _totalValue = InputField.Value;
            _calculationType = CalculationTypes.Plus;
            AfterClickHandler();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            _totalValue = InputField.Value;
            _calculationType = CalculationTypes.Minus;
            AfterClickHandler();
        }

        private void OutcomeButton_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            string error = "";
            if (_calculationType.HasValue && _totalValue.HasValue) // Did we have a previous number / calculation option?
                value = CalculationHelper.Calculate(_totalValue.Value, InputField.Value, _calculationType.Value, out error);
            else
                value = InputField?.Value ?? 0;

            if (!string.IsNullOrEmpty(error))
            {
                ErrorLabel.Text = error;
                _totalValue = null;
            }
            else
                _totalValue = value;
            
            _calculationType = null;
            AfterClickHandler();
        }

        // Detect all numeric characters at the form level and consume 1,
        // 4, and 7. Note that Form.KeyPreview must be set to true for this
        // event handler to be called.
        void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'x':
                case '*':
                    MultiplyButton_Click(sender, e);
                    break;
                case '/':
                    DivideButton_Click(sender, e);
                    break;
                case '+':
                    PlusButton_Click(sender, e);
                    break;
                case '-':
                    MinusButton_Click(sender, e);
                    break;
                case 'c':
                    ClearButton_Click(sender, e);
                    break;
                case '=':
                case '\r':
                    OutcomeButton_Click(sender, e);
                    break;
            }
        }

        private void AfterClickHandler()
        {
            InputField.ResetText();
            InputField.Focus();

            if (_totalValue != null)
            {
                OutcomeLabel.Text = "" + Math.Round(_totalValue.Value, 2);
                ErrorLabel.Text = "";
            }
            else
            {
                OutcomeLabel.Text = "";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _calculationType = null;
            _totalValue = null;
            AfterClickHandler();
        }
    }
}
