using System;

namespace Challenge.Compute
{
    public static class FibonacciSequence
    {
        // Based on the Abraham de Moivre and Daniel Bernoulli formula
        // https://en.wikipedia.org/wiki/Fibonacci_number#Closed-form_expression
        public static int Calculate(int n)
        {
            if (n < 1 || n > 100)
                return -1;

            if (n == 1)
                return n;

            double goldenRatio = (1 + Math.Sqrt(5)) / 2.0;
            double NegativeGoldenRatioInverse = -1 / goldenRatio;

            return Convert.ToInt32((Math.Pow(goldenRatio, n) - Math.Pow(NegativeGoldenRatioInverse, n)) / Math.Sqrt(5));
        }
    }
}