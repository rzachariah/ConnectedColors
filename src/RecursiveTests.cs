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

            var area = Recursive.FindMaxConnectedColors((mat));

            Assert.Equal(0, area);
        }

        [Fact]
        public void IsSizeOfUniformMatrix()
        {
            var mat = new Color[7,3];

            var area = Recursive.FindMaxConnectedColors((mat));

            Assert.Equal(21, area);
        }

        [Fact]
        public void CanSolveTechLeadExample()
        {
            var mat = Examples.TechLeadExample();

            var area = Recursive.FindMaxConnectedColors(mat);

            Assert.Equal(5, area);
        }

        [Fact]
        public void CanSolveAnotherExampleWithMaxOf5()
        {
            var mat = Examples.AnotherExampleWithMaxOf5();

            var area = Recursive.FindMaxConnectedColors(mat);

            Assert.Equal(5, area);
        }

        [Fact(Skip = "Throws StackOverflow")]
        public void StackOverflowOnMillionCellInput()
        {
            var mat = new Color[1000, 1000];
            var area = Recursive.FindMaxConnectedColors((mat));
            Assert.True(false);
        }
    }
}
