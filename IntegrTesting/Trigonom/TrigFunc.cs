using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrTesting.Trigonom
{
    public class TrigFunc
    {
        public static double Factorial(uint num)
        {
            if (num <= 1)
            {
                return 1d;
            }
            return num * Factorial(num - 1);
        }
        public static double Power(double num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }
        public static double Abs(double num)
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }
        public static double Cos(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((uint)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }
        public static double Sin(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n + 1) / Factorial((uint)(2 * n + 1));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Sin(x, n + 1, precision);
        }
        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }
        public static double Cotan(double x)
        {
            return Cos(x) / Sin(x);
        }
    }
}
