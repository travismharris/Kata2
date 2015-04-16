using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Kata2;

namespace Kata2Tests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2 );
        }

        [Fact]
        public void CreatingAnInstanceOfLoadFilePopulatesDataSet_IfFileExists()
        {
            LoadFile loader = new LoadFile();
            Assert.Equal(loader.dataFromSource != null, true);
            //should fail until I get LoadFile written
        }
    }
}
