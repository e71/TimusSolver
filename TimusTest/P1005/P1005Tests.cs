using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TimusTest.P1005
{
    class P1005Tests
    {
        [Fact]
        public void VerifySolverReturnsEmptyArrayOn0()
        {
            var solver = new TimusSolution.P1005.P1005Solver();
            var inputStream = new System.IO.StringReader(String.Format("{1}{0}{2}", Environment.NewLine, "0", String.Empty));
            var entries = solver.ReadInput(inputStream);

            Assert.Equal(0, entries.Length);
        }

        [Fact]
        public void VerifySolverParsesSingleElemssCorrectly()
        {
            var solver = new TimusSolution.P1005.P1005Solver();
            var inputStream = new System.IO.StringReader(String.Format("{1}{0}{2}", Environment.NewLine, "1", "5"));
            var entries = solver.ReadInput(inputStream);
            var expected = new int[] { 5 };

            Assert.True(expected.SequenceEqual(entries));
        }

        [Fact]
        public void VerifySolverParsesArraysCorrectly()
        {
            var solver = new TimusSolution.P1005.P1005Solver();
            var inputStream = new System.IO.StringReader(String.Format("{1}{0}{2}", Environment.NewLine, "5", "5 8 13 27 14"));
            var entries = solver.ReadInput(inputStream);
            var expected = new int[] { 5, 8, 13, 27, 14 };

            Assert.True(expected.SequenceEqual(entries));
        }
    }
}
