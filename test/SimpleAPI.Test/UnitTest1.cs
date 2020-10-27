using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class UnitTest2
    {
        readonly WeatherForecastController _controller = new WeatherForecastController();
        [Fact]
        public void TestGetReturn()
        {
            var returnValue = _controller.Get(1);
            Assert.Equal("Just Id Please", returnValue.Value);
        } 
    }   
}
