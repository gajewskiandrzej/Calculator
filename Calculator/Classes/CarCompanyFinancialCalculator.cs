using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    public class CarCompanyFinancialCalculator : CompanyFinancialCalculator, IFinancialCalculator //AbstractCompanyFinancialCalculator 
    {
        private const decimal CAR_FINANCE_FACTOR = 0.3m;
        private const decimal CAR_BONUS_FACTOR = 0.4m;
        private decimal _specialFactor = 0;

        public CarCompanyFinancialCalculator()
        {

        }

        public CarCompanyFinancialCalculator(decimal specialFactor)
        {
            _specialFactor = specialFactor;
        }

        public decimal CalculateAnnualFinances(decimal input, bool isSpecialTreatment)
        {
            if(isSpecialTreatment)
            {
                return input * 12 * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * 12 * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }

        public decimal CalculateAnnualFinances(decimal input)
        {
            if (_specialFactor != 0)
            {
                return input * 12 * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * _specialFactor;
            }
            return input * 12 * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }


        public decimal CalculateMonthlyFinances(decimal input, bool isSpecialTreatment)
        {
            if (isSpecialTreatment)
            {
                return input * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            if (_specialFactor != 0)
            {
                return input * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * _specialFactor;
            }
            return input * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }


        public decimal CalculateWeeklyFinances(decimal input, bool isSpecialTreatment)
        {
            if (isSpecialTreatment)
            {
                return input * 0.25m * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * CompanyFinancialCalculator.SPECIAL_TREATMENT_FACTOR;
            }
            return input * 0.25m * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }


        public decimal CalculateWeeklyFinances(decimal input)
        {
            if (_specialFactor != 0)
            {
                return input * 0.25m * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR * _specialFactor;
            }
            return input * 0.25m * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }

        public override decimal CalculateVat(decimal input)
        {
            return input * 0.3m;
        }
    }
}
