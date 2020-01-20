using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Sdk;

namespace ConnectedColors
{
    public class RecursiveTests
    {
        [Fact]
        public void IsZeroOnEmpty()
        {
            var mat = new Color[0, 0] { };

            var pathLength = Recursive.FindMaxConnectedColors((mat));

            Assert.Equal(0, pathLength);
        }

        [Fact]
        public void IsSizeOfUniformMatrix()
        {
            var mat = new Color[7,3];

            var pathLength = Recursive.FindMaxConnectedColors((mat));

            Assert.Equal(21, pathLength);
        }

        [Fact]
        public void CanSolveTechLeadExample()
        {
            var mat = Examples.TechLeadExample();

            var pathLength = Recursive.FindMaxConnectedColors(mat);

            Assert.Equal(5, pathLength);
        }

        [Fact]
        public void CanSolveAnotherExampleWithMaxOf5()
        {
            var mat = Examples.AnotherExampleWithMaxOf5();

            var pathLength = Recursive.FindMaxConnectedColors(mat);

            Assert.Equal(5, pathLength);
        }

        [Fact(Skip = "Throws StackOverflow")]
        public void StackOverflowOnMillionCellInput()
        {
            var mat = new Color[1000, 1000];
            var pathLength = Recursive.FindMaxConnectedColors((mat));
            Assert.True(false);
        }
    }
}
