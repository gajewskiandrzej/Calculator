using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IFinancialCalculator
    {
        /// <summary>
        /// It calculates finances per year
        /// </summary>
        decimal CalculateAnnualFinances(decimal input, bool isSpecialTreatment);

        /// <summary>
        /// It calculates finances per year
        /// </summary>
        decimal CalculateAnnualFinances(decimal input);

        /// <summary>
        /// It calculates finances per month
        /// </summary>
        decimal CalculateMonthlyFinances(decimal input, bool isSpecialTreatment);

        /// <summary>
        /// It calculates finances per month
        /// </summary>
        decimal CalculateMonthlyFinances(decimal input);


        /// <summary>
        /// It calculates finances per week
        /// </summary>
        decimal CalculateWeeklyFinances(decimal input, bool isSpecialTreatment);

        /// <summary>
        /// It calculates finances per week
        /// </summary>
        decimal CalculateWeeklyFinances(decimal input);
    }
}
