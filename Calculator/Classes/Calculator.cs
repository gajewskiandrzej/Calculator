using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private static decimal firstNumber, secondNumber;
        private static decimal? result = null;

        public static void PrintResult(decimal? result, string calculateResultInfo)
        {
            if (result == null && result == -1)
            {
                Console.WriteLine("Nieprawidłowy wynik.");
            }
            else
            {
                Console.WriteLine(calculateResultInfo + ":" + result);
            }
        }

        public static decimal? AddNumbers(string firstNumberReadLine, string secondNumberReadLine)
        {
            if (Decimal.TryParse(firstNumberReadLine, out firstNumber) && Decimal.TryParse(secondNumberReadLine, out secondNumber))
            {
                result = firstNumber + secondNumber;
            }
            return result;
        }

        public static decimal? SubtractNumbers(string firstNumberReadLine, string secondNumberReadLine)
        {
            if (Decimal.TryParse(firstNumberReadLine, out firstNumber) && Decimal.TryParse(secondNumberReadLine, out secondNumber))
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }

        public static decimal? MuliplyNumbers(string firstNumberReadLine, string secondNumberReadLine)
        {
            if (Decimal.TryParse(firstNumberReadLine, out firstNumber) && Decimal.TryParse(secondNumberReadLine, out secondNumber))
            {
                result = firstNumber * secondNumber;
            }
            return result;
        }

        public static decimal? DivideNumbers(string firstNumberReadLine, string secondNumberReadLine)
        {
            if (Decimal.TryParse(firstNumberReadLine, out firstNumber) && Decimal.TryParse(secondNumberReadLine, out secondNumber))
            {
                if (secondNumber == 0)
                {
                    return -1;
                }
                else
                {
                    result = firstNumber / secondNumber;
                }
            }
            return result;
        }
    }
}
