using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string name = "shawnkoon";
            Tester tester = new Tester();
            tester.Name = name;

            Assert.Equal(tester.Name, name);
            Assert.Equal(tester.ToString(), $"Hello World! {name}");
        }
    }
}
