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
            if (!backgroundWorker1.IsBusy) {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double numberOfMonths = double.Parse(textBoxNumberOfMonthsTab1.Text);
            double eachMonthSaving = double.Parse(textBoxEachMonthSavingsTab1.Text);
            double interestRate = double.Parse(textBoxInteresetRateTab1.Text);
            double totalSavings = eachMonthSaving;
            double interesetRateValue = 0;

            for (var i = 1; i <= numberOfMonths; i++)
            {
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Dupa luna: {i}{Environment.NewLine}")));

                    interesetRateValue = (totalSavings * (interestRate / 100)) / 12;
                //interesetRateValue = totalSavings * (interestRate / 100);
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare dobanda lunara: {string.Format("{0:0.00}", interesetRateValue)}{Environment.NewLine}")));
             

                    totalSavings = totalSavings + interesetRateValue + eachMonthSaving;

                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Economii: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));

                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare economii daca nu ai fi investit: {eachMonthSaving * i}{Environment.NewLine}")));
                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"Valoare profit: {string.Format("{0:0.00}", totalSavings - (eachMonthSaving * i))}{Environment.NewLine}")));

                textBoxDetailedStatusTab1.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab1.AppendText($"{Environment.NewLine}")));
            }

            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Dupa perioada totala{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Economii totale: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Valoare economii daca nu ai fi investit: {eachMonthSaving * numberOfMonths}{Environment.NewLine}")));
            textBoxSummaryStatusTab1.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab1.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings - (eachMonthSaving * numberOfMonths))}")));
        }

        private void buttonCalculeazaTab2_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double numberOfMonths = double.Parse(textBoxNumberOfMonthsTab2.Text);
            double initialInvestment = double.Parse(textBoxInitialInvestmentTab2.Text);
            double interestRate = double.Parse(textBoxInteresetRateTab2.Text);
            double totalSavings = initialInvestment;
            double interestRateValue = 0;

            for (var i = 1; i <= numberOfMonths; i++)
            {
                interestRateValue = totalSavings * (interestRate / 100);
                //interestRateValue = (totalSavings * (interestRate / 100)) / 12;
                totalSavings = totalSavings + interestRateValue;


                textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Dupa luna: {i}{Environment.NewLine}")));
                textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Valoare dobanda lunara: {string.Format("{0:0.00}", interestRateValue)}{Environment.NewLine}")));
                textBoxDetailedStatusTab2.Invoke((MethodInvoker)(() => textBoxDetailedStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));


            }
            textBoxSummaryStatusTab2.Invoke((MethodInvoker)(() => textBoxSummaryStatusTab2.AppendText($"Profit total: {string.Format("{0:0.00}", totalSavings)}{Environment.NewLine}")));


        }

    }
}