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
        void CalculateAnnualFinances();

        /// <summary>
        /// It calculates finances per month
        /// </summary>
        void CalculateMonthlyFinances();

        /// <summary>
        /// It calculates finances per week
        /// </summary>
        void CalculateWeeklyFinances();
    }
}
