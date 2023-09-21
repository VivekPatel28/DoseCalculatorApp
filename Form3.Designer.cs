namespace Dose_Calculations
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblDose = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBodyWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDose.ForeColor = System.Drawing.Color.Maroon;
            this.lblDose.Location = new System.Drawing.Point(629, 61);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(82, 23);
            this.lblDose.TabIndex = 42;
            this.lblDose.Text = "lblDose";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(605, 410);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(334, 17);
            this.lblCopyright.TabIndex = 34;
            this.lblCopyright.Text = "This application is developed by Vivek Patel @2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Recommended dose :";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMed.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(614, 33);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(64, 18);
            this.lblMed.TabIndex = 40;
            this.lblMed.Text = "lblMed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Selected medicine :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(20, 303);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalculate_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(574, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBodyWeight
            // 
            this.txtBodyWeight.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyWeight.Location = new System.Drawing.Point(20, 131);
            this.txtBodyWeight.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBodyWeight.Name = "txtBodyWeight";
            this.txtBodyWeight.Size = new System.Drawing.Size(101, 27);
            this.txtBodyWeight.TabIndex = 1;
            this.txtBodyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodyWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodyWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.MaximumSize = new System.Drawing.Size(420, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 72);
            this.label1.TabIndex = 31;
            this.label1.Text = "Please enter following details \r\n- bodyweight (in kg),\r\n- dose/kg (in mg), and \r\n" +
    "- medicine strength (in mg/5ml).";
            // 
            // txtDose
            // 
            this.txtDose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDose.Location = new System.Drawing.Point(20, 182);
            this.txtDose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(101, 27);
            this.txtDose.TabIndex = 2;
            this.txtDose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDose_KeyPress);
            // 
            // txtStrength
            // 
            this.txtStrength.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.Location = new System.Drawing.Point(20, 232);
            this.txtStrength.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(101, 27);
            this.txtStrength.TabIndex = 3;
            this.txtStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStrength_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "kg (BodyWeight)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "mg (recommended dose/kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "mg/5ml (Medicine Strength)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(944, 431);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBodyWeight);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 470);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDose;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBodyWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}