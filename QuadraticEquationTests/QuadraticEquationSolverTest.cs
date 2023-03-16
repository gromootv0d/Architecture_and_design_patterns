using QuadraticEquation;
using Xunit;

namespace QuadraticEquationTests
{
    public class QuadraticEquationSolverTest
    {
        [Fact]
        public void QuadraticEquationSolver_ShouldReturnEmptyArray_WhenNoRoots()
        {

            // Arrange
            double a = 1;
            double b = 0;
            double c = 1;

            // Act
            double[] roots = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Empty(roots);
        }

        [Fact]
        public void QuadraticEquationSolver_ShouldReturnTwoRoot_WhenItIsTwoRoot()
        {

            // Arrange
            double a = 1;
            double b = 0;
            double c = -1;

            // Act
            double[] roots = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Equal(2, roots.Length);
            Assert.Equal(1, roots[0]);
            Assert.Equal(-1, roots[1]);

        }

        [Fact]
        public void QuadraticEquationSolver_ShouldReturnOneRoot_WhenItIsOneRoot()
        {

            // Arrange
            double a = 1;
            double b = 2;
            double c = 1;

            // Act
            double[] roots = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Single(roots);
            Assert.Equal(-1, roots[0]);
        }

        [Fact]
        public void QuadraticEquationSolver_ShouldThrowArgumentException_WhenAIsZero()
        {

            // Arrange
            double a = 0;
            double b = 2;
            double c = 1;

            // Act
            Assert.Throws<ArgumentException>(() => QuadraticEquationSolver.Solve(a, b, c));
        }
    }
}