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
            double savings = eachMonthSavings;
            double interestValue;

            for (var i = 1; i <= totalInvestmentPeriodMonths; i++)
            {
                //calculation
                interestValue = (savings * (interestRate / 100)) / 12;
                savings += interestValue;

                //logs
                double savingsValueWithoutInvestment = eachMonthSavings * i;
                double profitValue = savings - eachMonthSavings * i;

                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Dupa luna: {i}{Environment.NewLine}" +
                    $"Valoare economii fara investitii: {savingsValueWithoutInvestment}{Environment.NewLine}" +
                    $"Valoare dobanda lunara: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}" +
                    $"Total economii: {string.Format("{0:0.00}", savings)}{Environment.NewLine}" +
                    $"Valoare profit: {string.Format("{0:0.00}", profitValue)}{Environment.NewLine}" +
                    $"{Environment.NewLine}")));

                //calculation
                savings += eachMonthSavings;
            }

            //logs
            double totalSavingsValueWithoutInvestment = eachMonthSavings * totalInvestmentPeriodMonths;
            double totalSavings = savings - eachMonthSavings;
            double totalProfitValue = totalSavings - totalSavingsValueWithoutInvestment;
            double totalProfitRate = (totalProfitValue * 100) / totalSavings;
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Valoare economii fara investitii: {totalSavingsValueWithoutInvestment}{Environment.NewLine}" +
                $"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}" +
                $"Profit total: {string.Format("{0:0.00}", totalProfitValue)}{Environment.NewLine}" +
                $"Rata profit total: {string.Format("{0:0.00}", totalProfitRate)}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Calculele au fost generate pentru:{Environment.NewLine}" +
                $"Perioada investitiei: {totalInvestmentPeriodMonths} luni{Environment.NewLine}" +
                $"Valarea investitiei lunare: {eachMonthSavings}{Environment.NewLine}" +
                $"Rata de profit anual: {interestRate}%{Environment.NewLine}" +
                $"{Environment.NewLine}=========================================={Environment.NewLine}{Environment.NewLine}")));
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
                            //calculation
                            interestValue = (totalSavings * (interestRate / 100)) / 12;
                            totalSavings += interestValue;

                            //logs
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa luna: {i}{Environment.NewLine}" +
                                $"Valoare dobanda lunara: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}" +
                                $"Profit: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}" +
                                $"{Environment.NewLine}")));
                        }
                        //logs
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}" +
                            $"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}" +
                            $"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
                case 3:
                    {
                        var monthIncrement = 3;
                        for (var i = 1; i <= totalDepositPeriodYears * 4; i++)
                        {
                            //calculation
                            interestValue = (totalSavings * (interestRate / 100)) / 4;
                            totalSavings += interestValue;

                            //logs
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa luna: {monthIncrement}{Environment.NewLine}" +
                                $"Valoare dobanda la 3 luni: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}" +
                                $"Profit: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}" +
                                $"{Environment.NewLine}")));

                            //calculation
                            monthIncrement += 3;
                        }
                        //logs
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}" +
                            $"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}" +
                            $"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
                case 12:
                    {
                        for (var i = 1; i <= totalDepositPeriodYears; i++)
                        {
                            //calculation
                            interestValue = totalSavings * (interestRate / 100);
                            totalSavings += interestValue;

                            //logs
                            textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa anul: {i}{Environment.NewLine}" +
                                $"Valoare dobanda anuala: {string.Format("{0:0.00}", interestValue)}{Environment.NewLine}" +
                                $"Profit: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}" +
                                $"{Environment.NewLine}")));
                        }
                        //logs
                        textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Valoare depozit initial: {string.Format("{0:0.00}", initialDepositValue)}{Environment.NewLine}" +
                            $"Total economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}" +
                            $"Profit total: {string.Format("{0:0.00}", totalSavings - initialDepositValue)}{Environment.NewLine}")));

                        break;
                    }
            }
            //logs
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"{Environment.NewLine}" +
                $"Calculele fost generate pentru:{Environment.NewLine}" +
                $"Perioada depozitului: {totalDepositPeriodYears} ani{Environment.NewLine}" +
                $"Termenul depozitului: {depositPeriod} luni{Environment.NewLine}" +
                $"Rata dobanda anuala: {interestRate}%{Environment.NewLine}" +
                $"Valoare depozit initial: {initialDepositValue}{Environment.NewLine}" +
                $"{Environment.NewLine}=========================================={Environment.NewLine}{Environment.NewLine}")));
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