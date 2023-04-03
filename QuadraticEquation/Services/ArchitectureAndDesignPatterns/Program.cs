using QuadraticEquation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureAndDesignPatterns
{
    public class Program
    {
        static void Main()
        {
            double a = 1;
            double b = 1;
            double c = 0;

            double[] roots = QuadraticEquationSolver.Solve(a, b, c);
            if (roots.Length == 0)
            {
                Console.WriteLine("The quadratic equation has no real roots.");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"The quadratic equation has a single root: {roots[0]}");
            }
            else
            {
                Console.WriteLine($"The quadratic equation has two real roots: {roots[0]} and {roots[1]}");
            }
        }
    }
}
