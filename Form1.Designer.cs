namespace Dose_Calculations
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPara250 = new System.Windows.Forms.Button();
            this.ckBoxKg = new System.Windows.Forms.CheckBox();
            this.ckBoxMg = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPara120 = new System.Windows.Forms.Button();
            this.btnIbu100 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolAdvance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAutoCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAutoMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.disclaimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter bodyweight (in kg) or dose (in mg)";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(25, 89);
            this.txtUser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(101, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Location = new System.Drawing.Point(455, 124);
            this.lblResult.MaximumSize = new System.Drawing.Size(380, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 18);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "lblResult";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(597, 404);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(334, 17);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "This application is developed by Vivek Patel @2023";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(579, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPara250
            // 
            this.btnPara250.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPara250.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara250.Location = new System.Drawing.Point(23, 159);
            this.btnPara250.Name = "btnPara250";
            this.btnPara250.Size = new System.Drawing.Size(111, 51);
            this.btnPara250.TabIndex = 4;
            this.btnPara250.Text = "Para 250mg/5ml";
            this.btnPara250.UseVisualStyleBackColor = true;
            this.btnPara250.Click += new System.EventHandler(this.btnPara250_Click);
            // 
            // ckBoxKg
            // 
            this.ckBoxKg.AutoSize = true;
            this.ckBoxKg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckBoxKg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxKg.Location = new System.Drawing.Point(136, 92);
            this.ckBoxKg.Name = "ckBoxKg";
            this.ckBoxKg.Size = new System.Drawing.Size(134, 20);
            this.ckBoxKg.TabIndex = 2;
            this.ckBoxKg.Text = "kg (Bodyweight)";
            this.ckBoxKg.UseVisualStyleBackColor = true;
            this.ckBoxKg.CheckedChanged += new System.EventHandler(this.ckBoxKg_CheckedChanged);
            // 
            // ckBoxMg
            // 
            this.ckBoxMg.AutoSize = true;
            this.ckBoxMg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckBoxMg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxMg.Location = new System.Drawing.Point(271, 92);
            this.ckBoxMg.Name = "ckBoxMg";
            this.ckBoxMg.Size = new System.Drawing.Size(94, 20);
            this.ckBoxMg.TabIndex = 3;
            this.ckBoxMg.Text = "mg (Dose)";
            this.ckBoxMg.UseVisualStyleBackColor = true;
            this.ckBoxMg.CheckedChanged += new System.EventHandler(this.ckBoxMg_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selected medicine :";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMed.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(619, 34);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(64, 18);
            this.lblMed.TabIndex = 21;
            this.lblMed.Text = "lblMed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 64);
            this.label3.MaximumSize = new System.Drawing.Size(470, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Recommended dose :";
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDose.ForeColor = System.Drawing.Color.Maroon;
            this.lblDose.Location = new System.Drawing.Point(634, 62);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(82, 23);
            this.lblDose.TabIndex = 23;
            this.lblDose.Text = "lblDose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Instructions :";
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(458, 268);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 30);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPara120
            // 
            this.btnPara120.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPara120.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara120.Location = new System.Drawing.Point(156, 159);
            this.btnPara120.Name = "btnPara120";
            this.btnPara120.Size = new System.Drawing.Size(111, 51);
            this.btnPara120.TabIndex = 5;
            this.btnPara120.Text = "Para 120mg/5ml";
            this.btnPara120.UseVisualStyleBackColor = true;
            this.btnPara120.Click += new System.EventHandler(this.btnPara120_Click);
            // 
            // btnIbu100
            // 
            this.btnIbu100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIbu100.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIbu100.Location = new System.Drawing.Point(289, 161);
            this.btnIbu100.Name = "btnIbu100";
            this.btnIbu100.Size = new System.Drawing.Size(111, 51);
            this.btnIbu100.TabIndex = 6;
            this.btnIbu100.Text = "Ibu 100mg/5ml";
            this.btnIbu100.UseVisualStyleBackColor = true;
            this.btnIbu100.Click += new System.EventHandler(this.btnIbu100_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdvance,
            this.toolManual,
            this.toolSettings,
            this.disclaimerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 26);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fast-Lane";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(25, 387);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(41, 15);
            this.lblCopy.TabIndex = 30;
            this.lblCopy.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 32;
            this.label7.Text = "Coming soon :)";
            // 
            // toolAdvance
            // 
            this.toolAdvance.BackColor = System.Drawing.Color.Gainsboro;
            this.toolAdvance.Name = "toolAdvance";
            this.toolAdvance.Size = new System.Drawing.Size(162, 22);
            this.toolAdvance.Text = "Advance Calculator";
            this.toolAdvance.Click += new System.EventHandler(this.toolAdvance_Click);
            // 
            // toolManual
            // 
            this.toolManual.BackColor = System.Drawing.Color.Gainsboro;
            this.toolManual.Name = "toolManual";
            this.toolManual.Size = new System.Drawing.Size(151, 22);
            this.toolManual.Text = "Manual Calculator";
            this.toolManual.Click += new System.EventHandler(this.toolManual_Click);
            // 
            // toolSettings
            // 
            this.toolSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.toolSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAutoCopy,
            this.toolAutoMinimize});
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Size = new System.Drawing.Size(80, 22);
            this.toolSettings.Text = "Settings";
            // 
            // toolAutoCopy
            // 
            this.toolAutoCopy.BackColor = System.Drawing.Color.Gainsboro;
            this.toolAutoCopy.CheckOnClick = true;
            this.toolAutoCopy.Name = "toolAutoCopy";
            this.toolAutoCopy.Size = new System.Drawing.Size(184, 22);
            this.toolAutoCopy.Text = "Auto-copy";
            this.toolAutoCopy.CheckedChanged += new System.EventHandler(this.toolAutoCopy_CheckedChanged);
            // 
            // toolAutoMinimize
            // 
            this.toolAutoMinimize.BackColor = System.Drawing.Color.Gainsboro;
            this.toolAutoMinimize.CheckOnClick = true;
            this.toolAutoMinimize.Name = "toolAutoMinimize";
            this.toolAutoMinimize.Size = new System.Drawing.Size(184, 22);
            this.toolAutoMinimize.Text = "Auto-minimize";
            this.toolAutoMinimize.CheckedChanged += new System.EventHandler(this.toolAutoMinimize_CheckedChanged);
            // 
            // disclaimerToolStripMenuItem
            // 
            this.disclaimerToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.disclaimerToolStripMenuItem.Name = "disclaimerToolStripMenuItem";
            this.disclaimerToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.disclaimerToolStripMenuItem.Text = "Disclaimer";
            this.disclaimerToolStripMenuItem.Click += new System.EventHandler(this.disclaimerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(944, 431);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIbu100);
            this.Controls.Add(this.btnPara120);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckBoxMg);
            this.Controls.Add(this.ckBoxKg);
            this.Controls.Add(this.btnPara250);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 470);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dose Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPara250;
        private System.Windows.Forms.CheckBox ckBoxKg;
        private System.Windows.Forms.CheckBox ckBoxMg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPara120;
        private System.Windows.Forms.Button btnIbu100;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolAdvance;
        private System.Windows.Forms.ToolStripMenuItem toolManual;
        private System.Windows.Forms.ToolStripMenuItem toolSettings;
        private System.Windows.Forms.ToolStripMenuItem toolAutoCopy;
        private System.Windows.Forms.ToolStripMenuItem toolAutoMinimize;
        private System.Windows.Forms.ToolStripMenuItem disclaimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

