using System;
using Xunit;
using Assignment3;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_returns_true_when_given_https()
        {
            var uri = new Uri("https://www.google.com/");

            var expected = Extensions.IsSecure(uri);

            Assert.True(expected);
        }

        [Fact]
        public void WordCount_returns_2_given_hello_world()
        {
            var input = "Hello World";

            var expected = 2;

            var actual = Extensions.WordCount(input);

            Assert.Equal(expected,actual);
        }
    }
}
