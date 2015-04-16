using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace Kata2Tests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2 );
        }
    }
}
