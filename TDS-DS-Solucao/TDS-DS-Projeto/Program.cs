using System;
using System.Security.Authentication;
using TDS_DS_Library;

namespace TDS_DS_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCalculate cCalculate = new CCalculate();
            CChecker cChecker = new CChecker();
            CConverter cConverter = new CConverter();
            CValidator cValidator = new CValidator();
            CComparator cComparator = new CComparator();
            CTitle cTitle = new CTitle();

            bool repete = true;

            while (repete)
            {
                cTitle.ExecuteTitlesMenu();
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        repete = false;
                        break;
                    case 1:
                        CHelloWorld.Execute();
                        break;
                    case 2:
                        cCalculate.Execute(345, 454, 6);
                        break;
                    case 3:
                        cCalculate.ExecuteCalculatorSimple();
                        break;
                    case 4:
                        cChecker.ExecuteOddorPair();
                        break;
                    case 5:
                        cConverter.ExecuteTemperatureConverter();
                        break;
                    case 6:
                        cChecker.ExecuteAgeCheck();
                        break;
                    case 7:
                        cCalculate.ExecuteCalculatorIMC();
                        break;
                    case 8:
                        cValidator.ExecutePositiveOrNegative();
                        break;
                    case 9:
                        cComparator.ExecuteNumberComparatorSimple();
                        break;
                    case 10:
                        cComparator.ExecuteNumberComparator();
                        break;
                    case 11:
                        cChecker.ExecuteLeapYearChecker();
                        break;
                    case 12:
                        cValidator.ExecuteValidatorPrime();
                        break;
                    case 13:
                        cCalculate.ExecuteCalculatorAverage();
                        break; 
                    default:
                        cTitle.ExecuteInvalidOption();
                        break;
                }
            }
        }
    }
}