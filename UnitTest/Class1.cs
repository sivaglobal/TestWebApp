using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace UnitTest
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(3, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
