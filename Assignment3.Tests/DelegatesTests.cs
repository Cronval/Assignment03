using System;
using Xunit;
using Assignment3;
using System.IO;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseString_returns_olleh_given_hello()
        {
            var input = "hello";
            
            var expected = "olleh";

            var writer = new StringWriter();
            Console.SetOut(writer);

            Delegates.ReverseString(input);

            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Product_returns_5_given_2dot5_and_2()
        {   
            var expected = 5;

            var actual = Delegates.Product(2.5m,2);

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void NumEqual_returns_true_given_4_and_string()
        { 
            var actual = Delegates.NumEqual(4,"04");

            Assert.True(actual);
        }
    }
}
