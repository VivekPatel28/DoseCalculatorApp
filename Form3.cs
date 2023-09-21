using System;
using System.Windows.Forms;

namespace Dose_Calculations
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btnClear.Visible = false;
            lblMed.Text = string.Empty;
            lblDose.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBodyWeight.Text = string.Empty;
            txtDose.Text = string.Empty;
            txtStrength.Text = string.Empty;
            lblDose.Text = string.Empty;
            lblMed.Text = string.Empty;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDose.Text, out decimal dose) &&
               decimal.TryParse(txtBodyWeight.Text, out decimal bodyWeight) &&
               decimal.TryParse(txtStrength.Text, out decimal strength))
            {
                ManualCalculation calculator = new ManualCalculation();
                decimal result = calculator.Manualcalculations(dose, bodyWeight, strength);

                lblDose.Text = $"{result}ml"; // Display the result
                btnClear.Visible=true;
                lblMed.Text = "Unknown";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Dose, Body Weight, and Strength.");
            }
        }

        private void txtBodyWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (decimal.TryParse(txtBodyWeight.Text, out _))
                {
                    txtDose.Focus();
                }
                // You can optionally show an error message if the input is not numeric
            }
        }

        private void txtDose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (decimal.TryParse(txtDose.Text, out _))
                {
                    txtStrength.Focus();
                }
                // You can optionally show an error message if the input is not numeric
            }
        }

        private void txtStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (decimal.TryParse(txtStrength.Text, out _))
                {
                    btnCalculate_Click(sender, e); // Trigger the calculation
                }
                // You can optionally show an error message if the input is not numeric
            }
        }


        private void btnCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnCalculate_Click(sender, e); // Trigger the calculation
            }
        }
    }
}
