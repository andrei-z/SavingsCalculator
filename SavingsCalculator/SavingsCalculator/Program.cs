//var numberOfMonths = 10;
//var eachMonthSaving = 1000;
//var interestRate = 3;

//Console.WriteLine("Enter for how many months you want to save");
//int numberOfMonths = int.Parse(Console.ReadLine());
//Console.WriteLine("\nEnter how much you want to save each month");
//int eachMonthSaving = int.Parse(Console.ReadLine());
//Console.WriteLine("\nWhat percentage will your investment return per year?");
//int interestRate = int.Parse(Console.ReadLine());

//double totalSavings = 0;
//double interesetRateValue = 0;

//Console.WriteLine("\n");

//for (var i = 1; i <= numberOfMonths; i++)
//{
//    Console.WriteLine($"After month: {i}");

//    if (i != 1)
//    {
//        interesetRateValue = ((totalSavings * interestRate) / 100) / 12;
//        Console.WriteLine($"Intereset rate value: {string.Format("{0:0.00}", interesetRateValue)}");
//    }

//    totalSavings = totalSavings + interesetRateValue + eachMonthSaving;
//    Console.WriteLine($"Savings: {string.Format("{0:0.00}", totalSavings)}");

//    Console.WriteLine($"Simple saving (without investment):  {eachMonthSaving * i}");
//    Console.WriteLine($"Investment profit: {string.Format("{0:0.00}", totalSavings - (eachMonthSaving * i))}\n"); ;
//}

//Console.WriteLine($"Total savings: {string.Format("{0:0.00}", totalSavings)}");
//Console.WriteLine($"Simple saving (without investment):  {eachMonthSaving * numberOfMonths}");
//Console.WriteLine($"Total investment profit: {string.Format("{0:0.00}", totalSavings - (eachMonthSaving * numberOfMonths))}");

//=============================================================================

Console.WriteLine("Enter for how many years do you want to save");
double numberOfYears = int.Parse(Console.ReadLine());
Console.WriteLine("\nWhat is the initial investment?");
double initialInvestment = int.Parse(Console.ReadLine());
Console.WriteLine("\nWhat is the interest rate per year?");
double interestRate = int.Parse(Console.ReadLine());

double totalSavings = initialInvestment;
double interestRateValue = 0;

for (var i = 1; i <= numberOfYears; i++)
{
    interestRateValue = totalSavings * (interestRate / 100);
    totalSavings = totalSavings + interestRateValue;

    Console.WriteLine($"After year: {i}");
    Console.WriteLine($"Intereset rate value: {string.Format("{0:0.00}", interestRateValue)}");
    Console.WriteLine($"Total savings: {string.Format("{0:0.00}", totalSavings)}\n");
}
