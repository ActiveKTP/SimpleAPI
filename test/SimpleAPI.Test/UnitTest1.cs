using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{


    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyname()
        {
            var returnValue = controller.Get();
            Assert.NotEqual("KTP", returnValue.ToString());
        }

        [Fact]
        public void Test1()
        {

        }
    }

}
