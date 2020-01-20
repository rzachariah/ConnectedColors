using Xunit;

namespace ConnectedColors
{
    public class IterativeTests
    {
        [Fact]
        public void IsZeroOnEmpty()
        {
            var mat = new Color[0, 0] { };

            var pathLength = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(0, pathLength);
        }

        [Fact]
        public void IsSizeOfUniformMatrix()
        {
            var mat = new Color[7,3];

            var pathLength = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(21, pathLength);
        }

        [Fact]
        public void CanSolveTechLeadExample()
        {
            var mat = Examples.TechLeadExample();

            var pathLength = Iterative.FindMaxConnectedColors(mat);

            Assert.Equal(5, pathLength);
        }

        [Fact]
        public void CanSolveAnotherExampleWithMaxOf5()
        {
            var mat = Examples.AnotherExampleWithMaxOf5();

            var pathLength = Iterative.FindMaxConnectedColors(mat);

            Assert.Equal(5, pathLength);
        }

        [Fact]
        public void CanHandleMillionCellInput()
        {
            var mat = new Color[1000, 1000];

            var pathLength = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(1000000, pathLength);
        }
    }
}
