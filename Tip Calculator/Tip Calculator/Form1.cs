using System;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class TipCalculatorForm : Form
    {
        float billAmount = 500;

        float tipAmount = 10;

        int noOfPeople = 2;

        public TipCalculatorForm()
        {
            InitializeComponent();
            
            
        }
        ////////////////Bill Input////////////////
        private void billInput_TextChanged(object sender, EventArgs e)
        {
            billAmount = GetInputValue(billInput);
            DisplayOutput();            
        }
        private void billInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == '.' && IsNotDecimalVal(billInput.Text)))/////Decimal input allowed
            {
                
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void billInput_Leave(object sender, EventArgs e)
        {
            UpdateBillDisplay();
        }
        private void UpdateBillDisplay()
        {
            if (billAmount == float.Parse(billAmount.ToString(".00")))
            {
                billInput.Text = billAmount.ToString(".00");
            }
        }

        ////////////////Tip Input////////////////
        private void tipInput_TextChanged(object sender, EventArgs e)
        {         
            tipAmount = GetInputValue(tipInput);            
            DisplayOutput();
        }
        private void tipInput_Leave(object sender, EventArgs e)
        {
            UpdateTipInput();
        }
        private void tipInput_Enter(object sender, EventArgs e)
        {
            tipInput.Text = tipInput.Text.Replace("%", "");
        }
        private void tipInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == '.' && IsNotDecimalVal(tipInput.Text)))/////Decimal input allowed
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void tipMinus_Click(object sender, EventArgs e)
        {
            if (tipAmount >= 1)
            {
                tipAmount--;
                UpdateTipInput();
            }
        }        
        private void tipPlus_Click(object sender, EventArgs e)
        {
            tipAmount++;
            UpdateTipInput();
        }
        private void UpdateTipInput()
        {
            tipInput.Text = tipAmount.ToString() + "%";
        }

        ///////////////People Input///////////////
        private void peopleInput_TextChanged(object sender, EventArgs e)
        {
            noOfPeople = GetInputValue(peopleInput, true);
            DisplayOutput();
        }

        private void peopleInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))/////////onlyIntegerInput
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void peopleMinus_Click(object sender, EventArgs e)
        {
            if (noOfPeople > 1)
                noOfPeople--;
            peopleInput.Text = noOfPeople.ToString();
        }

        private void peoplePlus_Click(object sender, EventArgs e)
        {
            noOfPeople++;
            peopleInput.Text = noOfPeople.ToString();
        }

        private bool IsNotDecimalVal(string text)
        {
            return !(text.Contains("."));

        }


        private void DisplayOutput()
        {
            float tipPerPerson;
            float totalPerPerson;
            tipPerPerson = (billAmount / noOfPeople) * tipAmount / 100;
            totalPerPerson = tipPerPerson + billAmount / noOfPeople;
            tipOutput.Text = "$" + tipPerPerson.ToString(".00");
            totalOutput.Text = "$" + totalPerPerson.ToString(".00");
        }

        private float GetInputValue(TextBox textBox)
        {
            float num = 01;
            string filterText=textBox.Text.Replace("%","");///remove %sign
            try
            {
                num = float.Parse(filterText);
            }
            catch
            {

            }
            if (num < 0)
            {
                num *= -1;
                textBox.Text = num.ToString();
            }
            
            return num;
        }
        private int GetInputValue(TextBox textBox, bool isPositivewholenumber)
        {
            int num = 0;
            try
            {
                num = int.Parse(textBox.Text);
            }
            catch
            {

            }

            if (num < 0)
            {
                num *= -1;
                textBox.Text = num.ToString();
            }
            if (num == 0)
            {
                num = 1;
                textBox.Text = num.ToString();
            }
            return num;
        }

        
    }
}
