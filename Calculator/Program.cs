using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Classes;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCompanyFinancialCalculator carCompanyFinancialCalculator = new CarCompanyFinancialCalculator();
            TreeCompanyFinancialCalculator treeCompanyFinancialCalculator = new TreeCompanyFinancialCalculator();

            List<IFinancialCalculator> financialCalculators = new List<IFinancialCalculator>();
            financialCalculators.Add(carCompanyFinancialCalculator);
            financialCalculators.Add(treeCompanyFinancialCalculator);

            //Przykłady pętli

            foreach (var item in financialCalculators)
            {
                CalculateFinance(item, 20000, 1500, 50);
            }

            //for (int i = 0; i < financialCalculators.Count; i++)
            //{
            //    CalculateFinance(financialCalculators[i], 20000, 1500, 50);
            //}

            //int j = 0;
            //while (j < financialCalculators.Count)
            //{
            //    CalculateFinance(financialCalculators[j], 20000, 1500, 50);
            //    j++;
            //}

            //int k = 0;
            //do
            //{
            //    CalculateFinance(financialCalculators[i], 20000, 1500, 50);
            //    k++;
            //} while (k < financialCalculators.Count);

            //CalculateFinance(carCompanyFinancialCalculator, 20000, 1500, 50);
            //decimal vatResult = carCompanyFinancialCalculator.CalculateVat(25000);

            //CalculateFinance(treeCompanyFinancialCalculator, 20000, 1500, 50);
            //vatResult = treeCompanyFinancialCalculator.CalculateVat(25000);
        }
        static void CalculateFinance(IFinancialCalculator typeCompanyFinancialCalculator, decimal annualInput, decimal monthlyInput, decimal weekInput)
        {
            decimal annualResult = typeCompanyFinancialCalculator.CalculateAnnualFinances(annualInput, isSpecialTreatment: true);
            decimal monhtlyResult = typeCompanyFinancialCalculator.CalculateMonthlyFinances(monthlyInput, isSpecialTreatment: true);
            decimal weekResult = typeCompanyFinancialCalculator.CalculateWeeklyFinances(weekInput, isSpecialTreatment: true);

            annualResult = typeCompanyFinancialCalculator.CalculateAnnualFinances(annualInput);
            monhtlyResult = typeCompanyFinancialCalculator.CalculateMonthlyFinances(monthlyInput);
            weekResult = typeCompanyFinancialCalculator.CalculateWeeklyFinances(weekInput);
        }
    }




    //Dotyczy klasy abstrackyjnej AbstractCompanyFinancialCalculator
    //    static void Main(string[] args)
    //    {
    //        AbstractCompanyFinancialCalculator carCompanyFinancialCalculator = new CarCompanyFinancialCalculator();
    //        AbstractCompanyFinancialCalculator treeCompanyFinancialCalculator = new TreeCompanyFinancialCalculator();

    //        CalculateFinance(carCompanyFinancialCalculator, 25000, 20000, 1500, 50);
    //        CalculateFinance(treeCompanyFinancialCalculator, 25000, 20000, 1500, 50);


    //    }
    //    static void CalculateFinance(AbstractCompanyFinancialCalculator typeCompanyFinancialCalculator, decimal vatInput, decimal annualInput, decimal monthlyInput, decimal weekInput)
    //    {
    //        decimal annualResult = typeCompanyFinancialCalculator.CalculateAnnualFinances(annualInput);
    //        decimal monhtlyResult = typeCompanyFinancialCalculator.CalculateMonthlyFinances(monthlyInput);
    //        decimal weekResult = typeCompanyFinancialCalculator.CalculateWeeklyFinances(weekInput);
    //        decimal vatResult = typeCompanyFinancialCalculator.CalculateVat(vatInput);
    //    }
    //}
}












//========================================================================================================
// Dotyczy klasy Calculator
//=========================================================================================================
//        static void Main(string[] args)
//        {
//            string firstNumberReadLine, secondNumberReadLine;
//            decimal? result;

//            Console.WriteLine("Podaj pierwszą liczbę: ");
//            firstNumberReadLine = Console.ReadLine();

//            Console.WriteLine("Podaj drugą liczbę: ");
//            secondNumberReadLine = Console.ReadLine();



//            result = Calculator.AddNumbers(firstNumberReadLine, secondNumberReadLine);
//            Calculator.PrintResult(result, "Dodawanie");

//            result = Calculator.SubtractNumbers(firstNumberReadLine, secondNumberReadLine);
//            Calculator.PrintResult(result, "Odejmowanie");

//            result = Calculator.MuliplyNumbers(firstNumberReadLine, secondNumberReadLine);
//            Calculator.PrintResult(result, "Mnożenie");

//            result = Calculator.DivideNumbers(firstNumberReadLine, secondNumberReadLine);
//            Calculator.PrintResult(result, "Dzielenie");


//            Console.ReadKey();
//        }
//    }
//}
