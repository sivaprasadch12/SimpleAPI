using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller=new WeatherForecastController(null);
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void GetReturnByName()
        {
           var value=controller.Get(1);
           Assert.Equal("siva",value.Value);
        }
    }
}
