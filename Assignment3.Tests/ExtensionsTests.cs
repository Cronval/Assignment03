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
    }
}
