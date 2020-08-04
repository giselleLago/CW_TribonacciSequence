using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_TribonacciSequence
{
    public class Kata
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n < 3 || signature.Length >= n)
            {
                return signature.Take(n).ToArray();
            }

            var newValue = signature[^1] +  signature[^2] + signature[^3];
            return Tribonacci(signature.Concat(new[] { newValue }).ToArray(), n);
        }

    }
}
