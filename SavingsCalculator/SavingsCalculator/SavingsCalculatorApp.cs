namespace SavingsCalculator
{
    public partial class SavingsCalculatorApp : Form
    {
        public SavingsCalculatorApp()
        {
            InitializeComponent();
        }

        private void buttonCalculeazaTab1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        #region tab1
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.Clear()));
            textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.Refresh()));

            double totalInvestmentPeriodMonths = double.Parse(textBoxTotalInvestmentPeriodMonthsTab1.Text);
            double eachMonthSavings = double.Parse(textBoxEachMonthSavingsTab1.Text);
            double interestRate = double.Parse(textBoxInteresetRateTab1.Text);
            double totalSavings = eachMonthSavings;
            double interestValue;

            for (var i = 1; i <= totalInvestmentPeriodMonths; i++)
            {
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Dupa luna: {i}{Environment.NewLine}")));

                interestValue = (totalSavings * (interestRate / 100)) / 12;
                totalSavings += interestValue;

                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare economii fara investitii: {eachMonthSavings * i}{Environment.NewLine}")));
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare dobanda lunara: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}")));
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare profit: {string.Format("{0:0.00}", totalSavings - (eachMonthSavings * i))}{Environment.NewLine}")));
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"{Environment.NewLine}")));

                totalSavings += eachMonthSavings;
            }

            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Valoare economii fara investitii: {eachMonthSavings * totalInvestmentPeriodMonths}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings - (eachMonthSavings * totalInvestmentPeriodMonths))}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Rata profit total: {string.Format("{0:0.00}", ((totalSavings - (eachMonthSavings * totalInvestmentPeriodMonths)) * 100) / (eachMonthSavings * totalInvestmentPeriodMonths))}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Calculele au fost generate pentru:{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Perioada investitiei: {totalInvestmentPeriodMonths} luni{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Valarea investitiei lunare: {eachMonthSavings}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Rata de profit anual: {interestRate}%{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"{Environment.NewLine}=========================================={Environment.NewLine}{Environment.NewLine}")));
        }

        private void buttonDeleteSummaryTab1_Click(object sender, EventArgs e)
        {
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.Clear()));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.Refresh()));
        }
        #endregion

        #region tab2
        private void buttonCalculeazaTab2_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.Clear()));
            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.Refresh()));

            double totalDepositPeriodYears = double.Parse(textBoxTotalDepositPeriodYearsTab2.Text);
            double initialDepositValue = double.Parse(textBoxInitialDepositValueTab2.Text);
            double interestRate = double.Parse(textBoxInteresetRateTab2.Text);
            double totalSavings = initialDepositValue;
            double interestValue;

            int depositPeriod = 0;
            if (checkedListBoxDepositPeriod.GetItemCheckState(0) == CheckState.Checked)
                depositPeriod = 1;
            else if (checkedListBoxDepositPeriod.GetItemCheckState(1) == CheckState.Checked)
                depositPeriod = 3;
            else if (checkedListBoxDepositPeriod.GetItemCheckState(2) == CheckState.Checked)
                depositPeriod = 12;

            switch (depositPeriod)
            {
                case 1:
                    {
                        for (var i = 1; i <= totalDepositPeriodYears * 12; i++)
                        {
                            interestValue = (totalSavings * (interestRate / 100)) / 12;
                            totalSavings += interestValue;

                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa luna: {i}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Valoare dobanda lunara: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"{Environment.NewLine}")));
                        }
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
                case 3:
                    {
                        var monthIncrement = 3;
                        for (var i = 1; i <= totalDepositPeriodYears * 4; i++)
                        {
                            interestValue = (totalSavings * (interestRate / 100)) / 4;
                            totalSavings += interestValue;
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa luna: {monthIncrement}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Valoare dobanda la 3 luni: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"{Environment.NewLine}")));
                            monthIncrement += 3;
                        }
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
                case 12:
                    {
                        for (var i = 1; i <= totalDepositPeriodYears; i++)
                        {
                            interestValue = totalSavings * (interestRate / 100);
                            totalSavings += interestValue;

                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa anul: {i}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Valoare dobanda anuala: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"{Environment.NewLine}")));
                        }
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
            }
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"{Environment.NewLine}"))); 
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Calculele fost generate pentru:{Environment.NewLine}")));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Perioada depozitului: {totalDepositPeriodYears} ani{Environment.NewLine}")));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Termenul depozitului: {depositPeriod}{Environment.NewLine}")));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Rata dobanda anuala: {interestRate}%{Environment.NewLine}")));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {initialDepositValue}{Environment.NewLine}")));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"{Environment.NewLine}=========================================={Environment.NewLine}{Environment.NewLine}")));
        }

        private void checkedListBoxDepositPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checklist = sender as CheckedListBox;
            var index = checklist.SelectedIndex;
            var count = checklist.Items.Count;
            for (var i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checklist.SetItemChecked(i, false);
                }
            }
        }

        private void buttonDeleteSummaryTab2_Click(object sender, EventArgs e)
        {
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.Clear()));
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.Refresh()));
        }
        #endregion
    }
}