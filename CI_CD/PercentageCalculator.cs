using System;

namespace PercentageLibrary
{
    public static class PercentageCalculator
    {

        public static double CalculatePercentOf(double value, double percent)
        {
            if (double.IsNaN(value) || double.IsNaN(percent))
                throw new ArgumentException("Значения не могут быть неопределёнными.");

            return value * percent / 100.0;
        }


        public static double FindBaseFromPercent(double percentValue, double percent)
        {
            if (double.IsNaN(percentValue) || double.IsNaN(percent))
                throw new ArgumentException("Значения не могут быть неопределёнными.");

            if (percent == 0)
                throw new DivideByZeroException("Процент не может быть равен нулю.");

            return percentValue * 100.0 / percent;
        }
    }
}
