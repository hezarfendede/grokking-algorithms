using System;
using Algorithms.Calculations;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.Calculations
{
    public class FactorialTests
    {
        [Fact(DisplayName = "FT-001: Factorial opeation throws an ArgumentOutOfRangeException when the number is negative.")]
        public void FT001()
        {
            // assign

            // act
            Action act = () => Factorial.Calculate(-1);

            // assert
            act.Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Theory(DisplayName = "FT-002: Factorial operation return the correct result")]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        [InlineData(9, 362880)]
        [InlineData(10, 3628800)]
        public void FT002(int input, int expected)
        {
            // assign

            // act
            var result = Factorial.Calculate(input);

            // assert
            result.Should().Be(expected);
        }

        [Fact(DisplayName = "FT-003: Factorial opeation throws NotImplementedException when the number is larger than 10.")]
        public void FT003()
        {
            // assign

            // act
            Action act = () => Factorial.Calculate(11);

            // assert
            act.Should()
                .Throw<NotImplementedException>();
        }
    }
}
