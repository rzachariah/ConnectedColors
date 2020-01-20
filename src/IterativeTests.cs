using Xunit;

namespace ConnectedColors
{
    public class IterativeTests
    {
        [Fact]
        public void IsZeroOnEmpty()
        {
            var mat = new Color[0, 0] { };

            var area = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(0, area);
        }

        [Fact]
        public void IsSizeOfUniformMatrix()
        {
            var mat = new Color[7,3];

            var area = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(21, area);
        }

        [Fact]
        public void CanSolveTechLeadExample()
        {
            var mat = Examples.TechLeadExample();

            var area = Iterative.FindMaxConnectedColors(mat);

            Assert.Equal(5, area);
        }

        [Fact]
        public void CanSolveAnotherExampleWithMaxOf5()
        {
            var mat = Examples.AnotherExampleWithMaxOf5();

            var area = Iterative.FindMaxConnectedColors(mat);

            Assert.Equal(5, area);
        }

        [Fact]
        public void CanHandleMillionCellInput()
        {
            var mat = new Color[1000, 1000];

            var area = Iterative.FindMaxConnectedColors((mat));

            Assert.Equal(1000000, area);
        }
    }
}
