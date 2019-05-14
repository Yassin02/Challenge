using System;

namespace Challenge.Compute
{
    public static class FibonacciSequence
    {
        // Based on the Abraham de Moivre and Daniel Bernoulli formula
        // https://en.wikipedia.org/wiki/Fibonacci_number#Closed-form_expression
        // The Function return int as mentionned in the challenge, means that the result cannot be greater than int.MaxValue: 2,147,483,647
        // in the calculation of the Fibonacci sequence at 46 Fib(46) = 1,836,311,903
        // hence we cannot have the result if n > 47 using a simple "int".
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