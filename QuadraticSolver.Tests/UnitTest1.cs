using Xunit;

namespace QuadraticSolver.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }


    public class QuadraticEquationSolverTests
    {
        [Theory]
        [InlineData(1, 0, 1)] // No real roots
        public void Solve_NoRealRoots_ReturnsEmpty(double a, double b, double c)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(1, 2, 1, -1)]
        public void Solve_OneRealRoot(double a, double b, double c, double expected)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);
            Assert.Single(result);
            Assert.Equal(expected, result[0], 5);
        }

        [Theory]
        [InlineData(1, 0, -1, 1, -1)]
        [InlineData(1, -3, 2, 2, 1)]
        public void Solve_TwoRealRoots(double a, double b, double c, double expected1, double expected2)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);
            Assert.Equal(2, result.Length);
            Assert.Contains(expected1, result);
            Assert.Contains(expected2, result);
        }
    }
}