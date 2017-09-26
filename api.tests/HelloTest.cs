using System;
using api.Controllers;
using Xunit;

namespace api.tests
{
    public class HelloTest
    {
        [Fact]
        public void HelloCoreTest()
        {
	        var hc = new HelloController();
			Assert.Equal("Hello from Core 2.0", hc.Get());
        }
    }
}
