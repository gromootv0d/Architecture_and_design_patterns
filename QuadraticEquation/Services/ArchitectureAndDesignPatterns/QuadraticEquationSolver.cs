using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class QuadraticEquationSolver
    {     
        public static double[] Solve(double a, double b, double c, double epsolon = double.Epsilon)
        {
            ValidateValues(a, b, c, epsolon);

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return Array.Empty<double>();
            }
            else if (discriminant == 0 || discriminant < epsolon)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
        }

        private static void ValidateValues(double a, double b, double c, double epsolon)
        {
            if (!double.IsFinite(a) || !double.IsFinite(b) || !double.IsFinite(c))
            {
                throw new ArgumentException("All inputs must be finite numbers.");
            }

            if (Math.Abs(a) < epsolon)
            {
                throw new ArgumentException("'a' cannot be zero.");
            }
        }
    }
}
