using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    public class CompanyFinancialCalculator
    {
        private const decimal VAT = 0.23m;
        public const decimal SPECIAL_TREATMENT_FACTOR = 1.2m;

        public virtual decimal CalculateVat(decimal input)
        {
            return input * VAT;
        }
    }
}
