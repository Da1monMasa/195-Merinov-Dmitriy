using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorChecker
    {
        public static double ValidateCalculator(double sum1, double sum2, string operation)
        {
            if (operation == "+")
            {
                return (sum1 + sum2);
            }

            if (operation == "-")
            {
                return sum1 - sum2;

            }
            if (operation == "*")
            {
                return (sum1 * sum2);

            }
            if (operation == "/")
            {
                
                try
                {


                    if (sum2 == 0)
                    {
                        
                        throw new DivideByZeroException();
                        

                    }
                    else
                        return (sum1 / sum2);

                }
                catch (DivideByZeroException e) //отлов исключения
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    return 1;
                }


            }

            return 0;
        }
        static public void Main()
        {
            double a = 0;
            double b = 0;



            Console.WriteLine("Введите число 1");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToDouble(Console.ReadLine());
            double res = CalculatorChecker.ValidateCalculator(a, b, "/");
            Console.WriteLine("res " + res);
        }

    }
}