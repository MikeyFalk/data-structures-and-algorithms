using System;
using Xunit;
using static LinkedLists.Program;

namespace LinkedLists
{
    public class LinkListChallengeTests
    {
        [Fact]
        public void Test1()
        {
        bool itworks = linkListActivity();
      Assert.True(itworks);
        }
    }
}
