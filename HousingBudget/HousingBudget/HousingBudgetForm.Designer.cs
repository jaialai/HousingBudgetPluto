﻿namespace HousingBudget
{
    partial class HousingBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HousingBudget));
            this.lblAnnualIncome = new System.Windows.Forms.Label();
            this.lblMonthlyDebt = new System.Windows.Forms.Label();
            this.lblNetHousingBudget = new System.Windows.Forms.Label();
            this.txtAnnualIncome = new System.Windows.Forms.TextBox();
            this.txtMonthlyDebt = new System.Windows.Forms.TextBox();
            this.txtNetHousingBudget = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMortgage = new System.Windows.Forms.ComboBox();
            this.lblMortgageType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnnualIncome
            // 
            this.lblAnnualIncome.AutoSize = true;
            this.lblAnnualIncome.Location = new System.Drawing.Point(43, 102);
            this.lblAnnualIncome.Name = "lblAnnualIncome";
            this.lblAnnualIncome.Size = new System.Drawing.Size(171, 20);
            this.lblAnnualIncome.TabIndex = 0;
            this.lblAnnualIncome.Text = "&Annual pre-tax income:";
            this.lblAnnualIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAnnualIncome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonthlyDebt
            // 
            this.lblMonthlyDebt.AutoSize = true;
            this.lblMonthlyDebt.Location = new System.Drawing.Point(43, 150);
            this.lblMonthlyDebt.Name = "lblMonthlyDebt";
            this.lblMonthlyDebt.Size = new System.Drawing.Size(177, 20);
            this.lblMonthlyDebt.TabIndex = 1;
            this.lblMonthlyDebt.Text = "&Monthly debt payments:";
            this.lblMonthlyDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetHousingBudget
            // 
            this.lblNetHousingBudget.AutoSize = true;
            this.lblNetHousingBudget.Location = new System.Drawing.Point(43, 259);
            this.lblNetHousingBudget.Name = "lblNetHousingBudget";
            this.lblNetHousingBudget.Size = new System.Drawing.Size(152, 20);
            this.lblNetHousingBudget.TabIndex = 2;
            this.lblNetHousingBudget.Text = "Net housing budget:";
            this.lblNetHousingBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNetHousingBudget.Click += new System.EventHandler(this.lblNetHousingBudget_Click);
            // 
            // txtAnnualIncome
            // 
            this.txtAnnualIncome.Location = new System.Drawing.Point(235, 102);
            this.txtAnnualIncome.Name = "txtAnnualIncome";
            this.txtAnnualIncome.Size = new System.Drawing.Size(151, 26);
            this.txtAnnualIncome.TabIndex = 2;
            this.txtAnnualIncome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMonthlyDebt
            // 
            this.txtMonthlyDebt.Location = new System.Drawing.Point(235, 150);
            this.txtMonthlyDebt.Name = "txtMonthlyDebt";
            this.txtMonthlyDebt.Size = new System.Drawing.Size(151, 26);
            this.txtMonthlyDebt.TabIndex = 3;
            // 
            // txtNetHousingBudget
            // 
            this.txtNetHousingBudget.Location = new System.Drawing.Point(235, 256);
            this.txtNetHousingBudget.Name = "txtNetHousingBudget";
            this.txtNetHousingBudget.ReadOnly = true;
            this.txtNetHousingBudget.Size = new System.Drawing.Size(151, 26);
            this.txtNetHousingBudget.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 327);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // comboBoxMortgage
            // 
            this.comboBoxMortgage.FormattingEnabled = true;
            this.comboBoxMortgage.Items.AddRange(new object[] {
            "Conventional",
            "FHA"});
            this.comboBoxMortgage.Location = new System.Drawing.Point(235, 200);
            this.comboBoxMortgage.Name = "comboBoxMortgage";
            this.comboBoxMortgage.Size = new System.Drawing.Size(144, 28);
            this.comboBoxMortgage.TabIndex = 4;
            this.comboBoxMortgage.Text = "Choose here";
            this.comboBoxMortgage.SelectedIndexChanged += new System.EventHandler(this.comboBoxMortgage_SelectedIndexChanged);
            // 
            // lblMortgageType
            // 
            this.lblMortgageType.AutoSize = true;
            this.lblMortgageType.Location = new System.Drawing.Point(43, 208);
            this.lblMortgageType.Name = "lblMortgageType";
            this.lblMortgageType.Size = new System.Drawing.Size(115, 20);
            this.lblMortgageType.TabIndex = 17;
            this.lblMortgageType.Text = "Mortgage &type:";
            this.lblMortgageType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HousingBudget
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 687);
            this.Controls.Add(this.lblMortgageType);
            this.Controls.Add(this.comboBoxMortgage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNetHousingBudget);
            this.Controls.Add(this.txtMonthlyDebt);
            this.Controls.Add(this.txtAnnualIncome);
            this.Controls.Add(this.lblNetHousingBudget);
            this.Controls.Add(this.lblMonthlyDebt);
            this.Controls.Add(this.lblAnnualIncome);
            this.Name = "HousingBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Housing Budget";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnualIncome;
        private System.Windows.Forms.Label lblMonthlyDebt;
        private System.Windows.Forms.Label lblNetHousingBudget;
        private System.Windows.Forms.TextBox txtAnnualIncome;
        private System.Windows.Forms.TextBox txtMonthlyDebt;
        private System.Windows.Forms.TextBox txtNetHousingBudget;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMortgage;
        private System.Windows.Forms.Label lblMortgageType;
    }
}

