using System;
using Xunit;
using MyLibrary;

namespace ClassLibraryTest
{

    public class FiboLibraryTest
    {
        private readonly Fibo fibo;
        
        public FiboLibraryTest()
        {
            fibo = new Fibo();
        }

        [Fact]
        public void TestCompute()
        {
            Assert.Equal(55, fibo.Compute(10));
            Assert.Equal(6765, fibo.Compute(20));
        }
    }
}
