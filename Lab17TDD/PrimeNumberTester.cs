using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab17TDD
{
    public class PrimeNumberTester
    {
        [Fact]
        public void TestNumber1()
        {
            int actual = PrimeNumber.GetPrimeIndex(1);
            int expected = 2;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber2()
        {
            int actual = PrimeNumber.GetPrimeIndex(2);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber3()
        {
            int actual = PrimeNumber.GetPrimeIndex(3);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber4()
        {
            int actual = PrimeNumber.GetPrimeIndex(4);
            int expected = 7;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber5()
        {
            int actual = PrimeNumber.GetPrimeIndex(5);
            int expected = 11;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber6()
        {
            int actual = PrimeNumber.GetPrimeIndex(6);
            int expected = 13;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber7()
        {
            int actual = PrimeNumber.GetPrimeIndex(7);
            int expected = 17;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber8()
        {
            int actual = PrimeNumber.GetPrimeIndex(8);
            int expected = 19;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber9()
        {
            int actual = PrimeNumber.GetPrimeIndex(9);
            int expected = 23;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber10()
        {
            int actual = PrimeNumber.GetPrimeIndex(10);
            int expected = 29;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber11()
        {
            int actual = PrimeNumber.GetPrimeIndex(11);
            int expected = 31;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber12()
        {
            int actual = PrimeNumber.GetPrimeIndex(12);
            int expected = 37;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber13()
        {
            int actual = PrimeNumber.GetPrimeIndex(13);
            int expected = 41;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber14()
        {
            int actual = PrimeNumber.GetPrimeIndex(14);
            int expected = 43;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestNumber15()
        {
            int actual = PrimeNumber.GetPrimeIndex(15);
            int expected = 47;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber16()
        {
            int actual = PrimeNumber.GetPrimeIndex(16);
            int expected = 53;
            Assert.Equal(expected, actual);
        }
    }
}
