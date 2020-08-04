using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.Test
{
    public class PrimeNumber_Tests
    {
      [Fact]
        public void TestPrime1()
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(1), 2);
        }

        [Fact]
        public void TestPrime2()
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(2), 3);
        }

        [Fact]
        public void TestPrime3()
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(3), 5);
        }

        [Fact]
        public void TestPrime4()
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(4), 7);
        }

        [Fact]
        public void TestPrime5()
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(5), 11);
        }

        [Fact]
        public void TestPrime6() // Not suppose to work
        {
            PrimeNumbers numbers = new PrimeNumbers();
            Assert.Equal(numbers.GetNPrime(6), 1);
        }
    }
}
