using System;
using System.IO;
using Xunit;

namespace hello_world.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void main_prints_hello_world()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            HelloWorld.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello World!", output);
        }
    }
}
