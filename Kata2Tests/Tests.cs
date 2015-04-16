using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Kata2Tests
{
    public class Tests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, (2 + 2));
        }

    }
}
