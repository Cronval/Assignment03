using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Find_Rowling_wizards_returns_4_wizards()
        {
            
            var actual = Queries.FindRowlingWizards();

            Assert.Equal(4,actual);

        }

        [Fact]
        public void Find_First_Sith_returns_1977()
        {
            
            var actual = Queries.FindFirstSith();

            Assert.Equal(1977,actual);
        }

        [Fact]
        public void Find_Harry_Potter_Wizards_returns_list_of_3()
        {
        
            var actual = Queries.FindHarryPotterWizards();

            Assert.Equal(3,actual.Count);
        }

        [Fact]
        public void Group_wizards_by_creator_returns_list()
        {
            var actual = Queries.GroupWizardsByCreator();

            Assert.Equal("Darth Maul", actual[0]);
            Assert.Equal("Darth Vader", actual[1]);
        }
    }
}
