namespace Dose_Calculations
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnIbu100 = new System.Windows.Forms.Button();
            this.btnPara120 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPara250 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn250to120 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn250to100 = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btn120to250 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIbu100
            // 
            this.btnIbu100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIbu100.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIbu100.Location = new System.Drawing.Point(296, 155);
            this.btnIbu100.Name = "btnIbu100";
            this.btnIbu100.Size = new System.Drawing.Size(111, 51);
            this.btnIbu100.TabIndex = 4;
            this.btnIbu100.Text = "Ibu 100mg/5ml";
            this.btnIbu100.UseVisualStyleBackColor = true;
            this.btnIbu100.Click += new System.EventHandler(this.btnIbu100_Click);
            // 
            // btnPara120
            // 
            this.btnPara120.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPara120.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara120.Location = new System.Drawing.Point(146, 155);
            this.btnPara120.Name = "btnPara120";
            this.btnPara120.Size = new System.Drawing.Size(131, 51);
            this.btnPara120.TabIndex = 3;
            this.btnPara120.Text = "Para 120mg/5ml";
            this.btnPara120.UseVisualStyleBackColor = true;
            this.btnPara120.Click += new System.EventHandler(this.btnPara120_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(431, 267);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 30);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Instructions :";
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDose.ForeColor = System.Drawing.Color.Maroon;
            this.lblDose.Location = new System.Drawing.Point(609, 65);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(82, 23);
            this.lblDose.TabIndex = 41;
            this.lblDose.Text = "lblDose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 68);
            this.label3.MaximumSize = new System.Drawing.Size(215, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Recommended dose :";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMed.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(596, 32);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(64, 18);
            this.lblMed.TabIndex = 39;
            this.lblMed.Text = "lblMed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Selected medicine :";
            // 
            // btnPara250
            // 
            this.btnPara250.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPara250.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara250.Location = new System.Drawing.Point(17, 155);
            this.btnPara250.Name = "btnPara250";
            this.btnPara250.Size = new System.Drawing.Size(111, 51);
            this.btnPara250.TabIndex = 2;
            this.btnPara250.Text = "Para 250mg/5ml";
            this.btnPara250.UseVisualStyleBackColor = true;
            this.btnPara250.Click += new System.EventHandler(this.btnPara250_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(559, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Location = new System.Drawing.Point(431, 131);
            this.lblResult.MaximumSize = new System.Drawing.Size(380, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 18);
            this.lblResult.TabIndex = 31;
            this.lblResult.Text = "lblResult";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(19, 55);
            this.txtUser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Please enter the dose (in ml)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "ml";
            // 
            // btn250to120
            // 
            this.btn250to120.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn250to120.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn250to120.Location = new System.Drawing.Point(19, 256);
            this.btn250to120.Name = "btn250to120";
            this.btn250to120.Size = new System.Drawing.Size(109, 69);
            this.btn250to120.TabIndex = 5;
            this.btn250to120.Text = "Para 250mg/5ml to 120mg/5ml";
            this.btn250to120.UseVisualStyleBackColor = true;
            this.btn250to120.Click += new System.EventHandler(this.btn250to120_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(19, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "More Advanced Tools";
            // 
            // btn250to100
            // 
            this.btn250to100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn250to100.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn250to100.Location = new System.Drawing.Point(147, 256);
            this.btn250to100.Name = "btn250to100";
            this.btn250to100.Size = new System.Drawing.Size(131, 69);
            this.btn250to100.TabIndex = 6;
            this.btn250to100.Text = "Para 250mg/5ml to Ibu 100mg/5ml";
            this.btn250to100.UseVisualStyleBackColor = true;
            this.btn250to100.Click += new System.EventHandler(this.btn250to100_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Maroon;
            this.lblWeight.Location = new System.Drawing.Point(618, 83);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 50;
            this.lblWeight.Text = "lblWeight";
            // 
            // btn120to250
            // 
            this.btn120to250.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn120to250.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn120to250.Location = new System.Drawing.Point(296, 256);
            this.btn120to250.Name = "btn120to250";
            this.btn120to250.Size = new System.Drawing.Size(111, 69);
            this.btn120to250.TabIndex = 7;
            this.btn120to250.Text = "Para 120mg/5ml to 250mg/5ml";
            this.btn120to250.UseVisualStyleBackColor = true;
            this.btn120to250.Click += new System.EventHandler(this.btn120to250_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "Please click the relevant medicine to get \r\nideal bodyweight for the provided dos" +
    "e.";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(604, 410);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(334, 17);
            this.lblCopyright.TabIndex = 53;
            this.lblCopyright.Text = "This application is developed by Vivek Patel @2023";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(944, 431);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn120to250);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btn250to100);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn250to120);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIbu100);
            this.Controls.Add(this.btnPara120);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPara250);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 470);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIbu100;
        private System.Windows.Forms.Button btnPara120;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPara250;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn250to120;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn250to100;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btn120to250;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCopyright;
    }
}