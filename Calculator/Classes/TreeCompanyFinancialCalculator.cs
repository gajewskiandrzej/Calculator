using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    public class TreeCompanyFinancialCalculator : CompanyFinancialCalculator, IFinancialCalculator //AbstractCompanyFinancialCalculator 
    {
        private const decimal TREE_FINANCE_FACTOR = 0.3m;

        public decimal CalculateAnnualFinances(decimal input, bool isSpecialTreatment)
        {
            if (isSpecialTreatment)
            {
                return input * 12 * TREE_FINANCE_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * 12 * TREE_FINANCE_FACTOR;
        }

        public decimal CalculateAnnualFinances(decimal input)
        {
            return input * 12 * TREE_FINANCE_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input, bool isSpecialTreatment)
        {
            if (isSpecialTreatment)
            {
                return input * TREE_FINANCE_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * TREE_FINANCE_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * TREE_FINANCE_FACTOR;
        }


        public decimal CalculateWeeklyFinances(decimal input, bool isSpecialTreatment)
        {
            if (isSpecialTreatment)
            {
                return input * 0.25m * TREE_FINANCE_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * 0.25m * TREE_FINANCE_FACTOR;
        }
        
        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * TREE_FINANCE_FACTOR;
        }


        public override decimal CalculateVat(decimal input)
        {
            return input * 0.5m;
        }
    }
}
