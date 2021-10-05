using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorChecker
    {
        public static double ValidateCalculator(double a, double b, string operation)
        {
            if (operation == "+")
            {
                return (a + b);
            }

            if (operation == "-")
            {
                return (a - b);

            }
            if (operation == "*")
            {
                return (a * b);

            }
            if (operation == "/")
            {
                if (b == 0.0D)
                {
                    throw new DivideByZeroException();
                }
                return (a / b);
                try
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Вы не можете делить на ноль");

                        return 1;
                    }
                    else
                        Console.WriteLine("Результат :" + " " + a / b);

                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return 0;
        }
        static public void Main()
        {
            double aa = 0;
            double ba = 0;

            Console.WriteLine("Введите число 1");
            aa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            ba = Convert.ToDouble(Console.ReadLine());
            double res = CalculatorChecker.ValidateCalculator(aa, ba, "*");
            Console.WriteLine("result: " + res);
        }
    }
}
