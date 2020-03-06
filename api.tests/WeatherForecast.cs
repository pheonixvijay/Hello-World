using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
