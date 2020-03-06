using api.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace api.tests
{
    [TestClass]
    public class WeatherForecast
    {
        [TestMethod]
        public void Test_TemperatureInFarnheit()
        {
            var model = new api.WeatherForecast
            {
                TemperatureC = 35
            };

            Assert.AreEqual(94, model.TemperatureF);
        }

        [TestMethod]
        public void Test_COntroller()
        {
            var _mockLogger = new Mock<ILogger<WeatherForecastController>>();


            var controller = new WeatherForecastController(_mockLogger.Object);

            List<api.WeatherForecast> response = controller.Get().ToList();

            Assert.AreEqual(5, response.Count);

        }
    }
}
