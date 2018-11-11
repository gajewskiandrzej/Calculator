using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class AbstractCompanyFinancialCalculator
    {
        /// <summary>
        /// It calculates finances per year
        /// </summary>
        public abstract decimal CalculateAnnualFinances(decimal input);

        /// <summary>
        /// It calculates finances per month
        /// </summary>
        public abstract decimal CalculateMonthlyFinances(decimal input);

        /// <summary>
        /// It calculates finances per week
        /// </summary>
        public abstract decimal CalculateWeeklyFinances(decimal input);

        public decimal CalculateVat(decimal input)
        {
            return input * 0.23m;
        }
    }
}
