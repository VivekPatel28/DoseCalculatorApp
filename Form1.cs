using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dose_Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.ActiveControl = txtUser;
            //txtUser.Focus();
            ckBoxKg.Checked = true;
            lblDose.Text = string.Empty;
            lblMed.Text = string.Empty;
            lblResult.Text = string.Empty;
            btnClear.Visible = false;
            btnCopy.Visible = false;
            toolAutoMinimize.Checked = Properties.Settings.Default.AutoMinimizeEnabled;
            toolAutoCopy.Checked = Properties.Settings.Default.AutoCopyEnabled;
            if (!toolAutoCopy.Checked)
            {
                lblCopy.Text = "Auto-copy status : Disabled";
            }
            
        }


        CalculationsByWeight calculationsByWeight = new CalculationsByWeight();
        CalculationsByMg CalculationsByMg = new CalculationsByMg();
        decimal value = 0;
        decimal ml = 0;

        private void toolAutoCopy_CheckedChanged(object sender, EventArgs e)
        {
            // Reading the setting
            bool autoCopyEnabled = Properties.Settings.Default.AutoCopyEnabled;

            if (toolAutoCopy.Checked)
            {
                // Updating the setting
                Properties.Settings.Default.AutoCopyEnabled = true; // or false
                lblCopy.Text = "Auto-copy status : Enabled \nPlease note : This function is currently only available for \"Fast-Lane\" medicines";
                
            }
            if (!toolAutoCopy.Checked)
            {
                // Updating the setting
                Properties.Settings.Default.AutoCopyEnabled = false; // or false
                lblCopy.Text = "Auto-copy status : Disabled";
                
            }
        }
        private void toolAutoMinimize_CheckedChanged(object sender, EventArgs e)
        {
            if(toolAutoMinimize.Checked)
            {
                Properties.Settings.Default.AutoMinimizeEnabled = true;
            }
            if(!toolAutoMinimize.Checked)
            {
                Properties.Settings.Default.AutoMinimizeEnabled= false;
            }
        }
        private void ckBoxMg_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMg.Checked)
            {
                ckBoxKg.Checked = false;
            }
        }

        private void ckBoxKg_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxKg.Checked == true)
            {
                ckBoxMg.Checked = false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResult.Text);
            if (toolAutoMinimize.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            lblResult.Text = string.Empty;
            lblDose.Text = string.Empty;
            lblMed.Text = string.Empty;
            btnCopy.Visible = false;
            btnClear.Visible = false;
        }

        private void btnPara250_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUser.Text, out value))
            {

                if (ckBoxKg.Checked == true)
                {
                    ml = Math.Min(calculationsByWeight.ParaWeightToVolume250(value), 20);
                    lblMed.Text = "Paracetamol 250mg/5ml (15mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                      $"Do not give at the same time as other paracetamol containing medications.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else if (ckBoxMg.Checked == true)
                {
                    ml = Math.Min(CalculationsByMg.ParaMgToVolume250(value), 20);
                    lblMed.Text = "Paracetamol 250mg/5ml (15mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                      $"Do not give at the same time as other paracetamol containing medications.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else
                {
                    lblDose.Text = string.Empty;
                    lblMed.Text = string.Empty;
                    lblResult.Text = "Welcome! Please select either kg (bodyweight) \nor mg (dose) to obtain the Results.";
                    lblResult.ForeColor = Color.Maroon;
                }
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

                if (ckBoxKg.Checked == true)
                {
                    ml = Math.Min(calculationsByWeight.ParaWeightToVolume120(value), 40);
                    lblMed.Text = "Paracetamol 120mg/5ml (15mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                      $"Do not give at the same time as other paracetamol containing medications.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else if (ckBoxMg.Checked == true)
                {
                    ml = Math.Min(CalculationsByMg.ParaMgToVolume120(value), 40);
                    lblMed.Text = "Paracetamol 120mg/5ml (15mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to every FOUR to SIX hours when required for pain or fever. Maximum of FOUR doses in 24 hours. " +
                      $"Do not give at the same time as other paracetamol containing medications.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else
                {
                    lblDose.Text = string.Empty;
                    lblMed.Text = string.Empty;
                    lblResult.Text = "Welcome! Please select either kg (bodyweight) \nor mg (dose) to obtain the Results.";
                    lblResult.ForeColor = Color.Maroon;
                }
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


                if (ckBoxKg.Checked == true)
                {
                    ml = Math.Min(calculationsByWeight.IbuWeightToVolume100(value), 20);
                    lblMed.Text = "Ibuprofen 100mg/5ml (10mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to THREE times daily with food or milk when required for pain or inflammation. Maximum of THREE doses in 24 hours.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else if (ckBoxMg.Checked == true)
                {
                    ml = Math.Min(CalculationsByMg.IbuWeightToVolume100(value), 20);
                    lblMed.Text = "Ibuprofen 100mg/5ml (10mg/kg)";
                    lblDose.Text = $"{ml}ml";
                    lblResult.Text = ($"Shake well and give {ml}ml " +
                      $"up to THREE times daily with food or milk when required for pain or inflammation. Maximum of THREE doses in 24 hours.");
                    btnClear.Visible = true;
                    btnCopy.Visible = true;
                    if (toolAutoCopy.Checked == true)
                    {
                        btnCopy.PerformClick();
                    }
                }
                else
                {
                    lblDose.Text = string.Empty;
                    lblMed.Text = string.Empty;
                    lblResult.Text = "Welcome! Please select either kg (bodyweight) \nor mg (dose) to obtain the Results.";
                    lblResult.ForeColor = Color.Maroon;
                }
            }
            else
            {
                MessageBox.Show("Welcome!!! Please enter a valid number.");
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPara250.PerformClick(); // Trigger the button's click event
                e.Handled = true; // Prevent the "ding" sound
            }
        }

        private void toolAdvance_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }


        private void toolManual_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void disclaimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //   lblCopyright.Text = "This application is developed by Vivek Patel " + Convert.ToChar(169) + " 2023";
        // }

    }
}
