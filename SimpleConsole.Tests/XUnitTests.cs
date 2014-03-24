using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace SimpleConsole.Tests
{
    public class XUnitTests
    {
        [Fact]
        public void MyTest()
        {
            Assert.Equal(4, 2 + 2);
        }
        
        [Theory]
        [InlineData(4,2,2)]
        [InlineData(8,4,4)]
        [InlineData(16,8,8)]
        public void MyTest2(int result, int add1, int add2)
        {
            Assert.Equal(result, add1 + add2);
        }
    }
}
