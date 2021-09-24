using System;
using Xunit;
using Assignment3;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseString_returns_olleh_given_hello()
        {
            var input = "hello";
            
            var expected = "olleh";

            var actual = Delegates.ReverseString(input);

            Assert.Equal(expected,actual);
        }
    }
}
