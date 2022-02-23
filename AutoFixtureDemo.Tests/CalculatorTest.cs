﻿using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTwoPositiveNumbers()
        {
            var sut = new Calculator();
            sut.Add(1);
            sut.Add(2);

            Assert.Equal(1 + 2, sut.Value);
        }

        [Fact]
        public void AddZeroAndPositiveNumber()
        {
            var sut = new Calculator();

            sut.Add(0);
            sut.Add(2);

            Assert.Equal(2, sut.Value);
        }

        [Fact]
        public void AddNegativeAndPositiveNumber()
        {
            var sut = new Calculator();

            sut.Add(-5);
            sut.Add(1);

            Assert.Equal(-4, sut.Value);
        }
    }
}
