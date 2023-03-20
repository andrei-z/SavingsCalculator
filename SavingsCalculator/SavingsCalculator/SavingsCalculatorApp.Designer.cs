namespace SavingsCalculator
{
    partial class SavingsCalculatorApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            buttonDeleteSummaryTab1 = new Button();
            textBoxSummaryStatusTab1 = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxDetailedStatusTab1 = new RichTextBox();
            textBoxInteresetRateTab1 = new TextBox();
            textBoxEachMonthSavingsTab1 = new TextBox();
            textBoxTotalInvestmentPeriodMonthsTab1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCalculeazaTab1 = new Button();
            tabPage2 = new TabPage();
            buttonDeleteSummaryTab2 = new Button();
            label11 = new Label();
            checkedListBoxDepositPeriod = new CheckedListBox();
            buttonCalculeazaTab2 = new Button();
            textBoxSummaryStatusTab2 = new RichTextBox();
            textBoxDetailedStatusTab2 = new RichTextBox();
            textBoxInteresetRateTab2 = new TextBox();
            textBoxTotalDepositPeriodYearsTab2 = new TextBox();
            textBoxInitialDepositValueTab2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControlMain.Location = new Point(1, 1);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1164, 640);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(buttonDeleteSummaryTab1);
            tabPage1.Controls.Add(textBoxSummaryStatusTab1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxDetailedStatusTab1);
            tabPage1.Controls.Add(textBoxInteresetRateTab1);
            tabPage1.Controls.Add(textBoxEachMonthSavingsTab1);
            tabPage1.Controls.Add(textBoxTotalInvestmentPeriodMonthsTab1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonCalculeazaTab1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1156, 612);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculator de investitii";
            // 
            // buttonDeleteSummaryTab1
            // 
            buttonDeleteSummaryTab1.Location = new Point(634, 304);
            buttonDeleteSummaryTab1.Name = "buttonDeleteSummaryTab1";
            buttonDeleteSummaryTab1.Size = new Size(75, 23);
            buttonDeleteSummaryTab1.TabIndex = 11;
            buttonDeleteSummaryTab1.Text = "Sterge";
            buttonDeleteSummaryTab1.UseVisualStyleBackColor = true;
            buttonDeleteSummaryTab1.Click += buttonDeleteSummaryTab1_Click;
            // 
            // textBoxSummaryStatusTab1
            // 
            textBoxSummaryStatusTab1.BackColor = Color.White;
            textBoxSummaryStatusTab1.Location = new Point(634, 26);
            textBoxSummaryStatusTab1.Name = "textBoxSummaryStatusTab1";
            textBoxSummaryStatusTab1.ReadOnly = true;
            textBoxSummaryStatusTab1.Size = new Size(365, 272);
            textBoxSummaryStatusTab1.TabIndex = 10;
            textBoxSummaryStatusTab1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(634, 5);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Sumar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 5);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Desfasurator";
            // 
            // textBoxDetailedStatusTab1
            // 
            textBoxDetailedStatusTab1.BackColor = Color.White;
            textBoxDetailedStatusTab1.Location = new Point(210, 26);
            textBoxDetailedStatusTab1.Name = "textBoxDetailedStatusTab1";
            textBoxDetailedStatusTab1.ReadOnly = true;
            textBoxDetailedStatusTab1.Size = new Size(365, 515);
            textBoxDetailedStatusTab1.TabIndex = 7;
            textBoxDetailedStatusTab1.Text = "";
            // 
            // textBoxInteresetRateTab1
            // 
            textBoxInteresetRateTab1.Location = new Point(6, 145);
            textBoxInteresetRateTab1.Name = "textBoxInteresetRateTab1";
            textBoxInteresetRateTab1.Size = new Size(100, 23);
            textBoxInteresetRateTab1.TabIndex = 6;
            // 
            // textBoxEachMonthSavingsTab1
            // 
            textBoxEachMonthSavingsTab1.Location = new Point(5, 83);
            textBoxEachMonthSavingsTab1.Name = "textBoxEachMonthSavingsTab1";
            textBoxEachMonthSavingsTab1.Size = new Size(100, 23);
            textBoxEachMonthSavingsTab1.TabIndex = 5;
            // 
            // textBoxTotalInvestmentPeriodMonthsTab1
            // 
            textBoxTotalInvestmentPeriodMonthsTab1.Location = new Point(6, 24);
            textBoxTotalInvestmentPeriodMonthsTab1.Name = "textBoxTotalInvestmentPeriodMonthsTab1";
            textBoxTotalInvestmentPeriodMonthsTab1.Size = new Size(100, 23);
            textBoxTotalInvestmentPeriodMonthsTab1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 127);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 3;
            label3.Text = "Rata de profit anual (%):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 65);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 2;
            label2.Text = "Valoare investitiei lunare:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "Perioada investitiei (in luni):";
            // 
            // buttonCalculeazaTab1
            // 
            buttonCalculeazaTab1.Location = new Point(5, 193);
            buttonCalculeazaTab1.Name = "buttonCalculeazaTab1";
            buttonCalculeazaTab1.Size = new Size(100, 23);
            buttonCalculeazaTab1.TabIndex = 0;
            buttonCalculeazaTab1.Text = "Calculeaza";
            buttonCalculeazaTab1.UseVisualStyleBackColor = true;
            buttonCalculeazaTab1.Click += buttonCalculeazaTab1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(buttonDeleteSummaryTab2);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(checkedListBoxDepositPeriod);
            tabPage2.Controls.Add(buttonCalculeazaTab2);
            tabPage2.Controls.Add(textBoxSummaryStatusTab2);
            tabPage2.Controls.Add(textBoxDetailedStatusTab2);
            tabPage2.Controls.Add(textBoxInteresetRateTab2);
            tabPage2.Controls.Add(textBoxTotalDepositPeriodYearsTab2);
            tabPage2.Controls.Add(textBoxInitialDepositValueTab2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1156, 612);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Calculator pentru depozit";
            // 
            // buttonDeleteSummaryTab2
            // 
            buttonDeleteSummaryTab2.Location = new Point(634, 304);
            buttonDeleteSummaryTab2.Name = "buttonDeleteSummaryTab2";
            buttonDeleteSummaryTab2.Size = new Size(75, 23);
            buttonDeleteSummaryTab2.TabIndex = 13;
            buttonDeleteSummaryTab2.Text = "Sterge";
            buttonDeleteSummaryTab2.UseVisualStyleBackColor = true;
            buttonDeleteSummaryTab2.Click += buttonDeleteSummaryTab2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 5);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 12;
            label11.Text = "Tipul depozitului";
            // 
            // checkedListBoxDepositPeriod
            // 
            checkedListBoxDepositPeriod.BackColor = SystemColors.Menu;
            checkedListBoxDepositPeriod.BorderStyle = BorderStyle.None;
            checkedListBoxDepositPeriod.CheckOnClick = true;
            checkedListBoxDepositPeriod.FormattingEnabled = true;
            checkedListBoxDepositPeriod.Items.AddRange(new object[] { "1 luna", "3 luni ", "12 luni" });
            checkedListBoxDepositPeriod.Location = new Point(5, 25);
            checkedListBoxDepositPeriod.Name = "checkedListBoxDepositPeriod";
            checkedListBoxDepositPeriod.Size = new Size(120, 54);
            checkedListBoxDepositPeriod.TabIndex = 11;
            checkedListBoxDepositPeriod.SelectedIndexChanged += checkedListBoxDepositPeriod_SelectedIndexChanged;
            // 
            // buttonCalculeazaTab2
            // 
            buttonCalculeazaTab2.Location = new Point(5, 287);
            buttonCalculeazaTab2.Name = "buttonCalculeazaTab2";
            buttonCalculeazaTab2.Size = new Size(100, 23);
            buttonCalculeazaTab2.TabIndex = 10;
            buttonCalculeazaTab2.Text = "Calculeaza";
            buttonCalculeazaTab2.UseVisualStyleBackColor = true;
            buttonCalculeazaTab2.Click += buttonCalculeazaTab2_Click;
            // 
            // textBoxSummaryStatusTab2
            // 
            textBoxSummaryStatusTab2.BackColor = Color.White;
            textBoxSummaryStatusTab2.Location = new Point(634, 26);
            textBoxSummaryStatusTab2.Name = "textBoxSummaryStatusTab2";
            textBoxSummaryStatusTab2.ReadOnly = true;
            textBoxSummaryStatusTab2.Size = new Size(365, 272);
            textBoxSummaryStatusTab2.TabIndex = 9;
            textBoxSummaryStatusTab2.Text = "";
            // 
            // textBoxDetailedStatusTab2
            // 
            textBoxDetailedStatusTab2.BackColor = Color.White;
            textBoxDetailedStatusTab2.Location = new Point(210, 26);
            textBoxDetailedStatusTab2.Name = "textBoxDetailedStatusTab2";
            textBoxDetailedStatusTab2.ReadOnly = true;
            textBoxDetailedStatusTab2.Size = new Size(365, 515);
            textBoxDetailedStatusTab2.TabIndex = 8;
            textBoxDetailedStatusTab2.Text = "";
            // 
            // textBoxInteresetRateTab2
            // 
            textBoxInteresetRateTab2.Location = new Point(5, 238);
            textBoxInteresetRateTab2.Name = "textBoxInteresetRateTab2";
            textBoxInteresetRateTab2.Size = new Size(100, 23);
            textBoxInteresetRateTab2.TabIndex = 7;
            // 
            // textBoxTotalDepositPeriodYearsTab2
            // 
            textBoxTotalDepositPeriodYearsTab2.Location = new Point(5, 170);
            textBoxTotalDepositPeriodYearsTab2.Name = "textBoxTotalDepositPeriodYearsTab2";
            textBoxTotalDepositPeriodYearsTab2.Size = new Size(100, 23);
            textBoxTotalDepositPeriodYearsTab2.TabIndex = 6;
            // 
            // textBoxInitialDepositValueTab2
            // 
            textBoxInitialDepositValueTab2.Location = new Point(5, 110);
            textBoxInitialDepositValueTab2.Name = "textBoxInitialDepositValueTab2";
            textBoxInitialDepositValueTab2.Size = new Size(100, 23);
            textBoxInitialDepositValueTab2.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(634, 5);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 4;
            label10.Text = "Sumar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(210, 5);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 3;
            label9.Text = "Desfasurator";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 220);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 2;
            label8.Text = "Dobanda anuala (%): ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 152);
            label7.Name = "label7";
            label7.Size = new Size(158, 15);
            label7.TabIndex = 1;
            label7.Text = "Perioada depozitului (in ani):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 92);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 0;
            label6.Text = "Valoare depozit initial:";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // SavingsCalculatorApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 573);
            Controls.Add(tabControlMain);
            Name = "SavingsCalculatorApp";
            Text = "Calculator de economii";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonCalculeazaTab1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxInteresetRateTab1;
        private TextBox textBoxEachMonthSavingsTab1;
        private TextBox textBoxTotalInvestmentPeriodMonthsTab1;
        private RichTextBox textBoxDetailedStatusTab1;
        private Label label4;
        private RichTextBox textBoxSummaryStatusTab1;
        private Label label5;
        private TextBox textBoxInteresetRateTab2;
        private TextBox textBoxTotalDepositPeriodYearsTab2;
        private TextBox textBoxInitialDepositValueTab2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button buttonCalculeazaTab2;
        private RichTextBox textBoxSummaryStatusTab2;
        private RichTextBox textBoxDetailedStatusTab2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CheckedListBox checkedListBoxDepositPeriod;
        private Label label11;
        private Button buttonDeleteSummaryTab2;
        private Button buttonDeleteSummaryTab1;
    }
}