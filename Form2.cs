using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dose_Calculations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            lblDose.Text = string.Empty;
            lblMed.Text = string.Empty;
            lblResult.Text = string.Empty;
            btnCopy.Visible = false;
            btnClear.Visible = false;
            lblWeight.Text = string.Empty;
        }
        
        CalculationsByVolume calculationsByVolume = new CalculationsByVolume();
        ConvertPara ConvertPara = new ConvertPara();
        ManualCalculation ManualCalculation = new ManualCalculation();
        decimal value = 0;
        decimal ml = 0;
        private void btnPara250_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Selected Medicine :";
                label3.Text = "Patient's body weight should be more than :";
                lblMed.Text = "Paracetamol 250mg/5ml (15mg/kg)";
                lblWeight.Text = $"{calculationsByVolume.ParaVolumeToWeight250(value)}kg.";
                label4.Text = string.Empty;
                lblResult.Text = string.Empty;
                lblDose.Text= string.Empty;
                btnCopy.Visible = false;
                btnClear.Visible = true;
            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }

        private void btnPara120_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Selected Medicine :";
                label3.Text = "Patient's body weight should be more than :";
                lblMed.Text = "Paracetamol 120mg/5ml (15mg/kg)";
                lblWeight.Text = $"{calculationsByVolume.ParaVolumeToWeight120(value)}kg.";
                label4.Text = string.Empty;
                lblResult.Text = string.Empty;
                lblDose.Text = string.Empty;
                btnCopy.Visible = false;
                btnClear.Visible = true;
            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }
        private void btnIbu100_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Selected Medicine :";
                label3.Text = "Patient's body weight should be more than :";
                lblMed.Text = "Ibuprofen 100mg/5ml (10mg/kg)";
                lblWeight.Text = $"{calculationsByVolume.IbuVolumeToWeight100(value)}kg.";
                label4.Text = string.Empty;
                lblResult.Text = string.Empty;
                lblDose.Text = string.Empty;
                btnCopy.Visible = false;
                btnClear.Visible = true;
            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }

        }

        private void btn250to120_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Showing results for :";
                ml = Math.Min(ConvertPara.Para250To120(value), 40);
                lblMed.Text = "Paracetamol 120mg/5ml (15mg/kg)";
                label3.Text = "Recommended dose :";
                label4.Text = "Instructions :";
                lblDose.Text = $"{ml}ml";
                lblResult.Text = ($"Shake well and give {ml}ml " +
                    $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                    $"Do not give at the same time as other paracetamol containing medications.");
                btnCopy.Visible = true;
                lblWeight.Text = string.Empty;
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }

        private void btn120to250_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Showing results for :";
                ml = Math.Min(ConvertPara.Para120To250(value), 20);
                lblMed.Text = "Paracetamol 250mg/5ml (15mg/kg)";
                label3.Text = "Recommended dose :";
                label4.Text = "Instructions :";
                lblDose.Text = $"{ml}ml";
                lblResult.Text = ($"Shake well and give {ml}ml " +
                    $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                    $"Do not give at the same time as other paracetamol containing medications.");
                btnCopy.Visible = true;
                lblWeight.Text = string.Empty;
                btnClear.Visible = true;

            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }
        private void btn250to100_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {
                label2.Text = "Showing results for :";
                ml = Math.Min(ConvertPara.Para250ToIbu100(value), 20);
                lblMed.Text = "Ibuprofen 100mg/5ml (10mg/kg)";
                label3.Text = "Recommended dose :";
                label4.Text = "Instructions :";
                lblDose.Text = $"{ml}ml";
                lblResult.Text = ($"Shake well and give {ml}ml " +
                    $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                    $"Do not give at the same time as other paracetamol containing medications.");
                btnCopy.Visible = true;
                lblWeight.Text = string.Empty;
                btnClear.Visible = true;
            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            lblDose.Text = string.Empty;
            lblMed.Text = string.Empty;
            lblResult.Text = string.Empty;
            btnCopy.Visible = false;
            lblWeight.Text = string.Empty;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResult.Text);
            if (Properties.Settings.Default.AutoMinimizeEnabled)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }
    }
}
