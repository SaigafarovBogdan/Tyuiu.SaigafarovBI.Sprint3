using Tyuiu.SaigafarovBI.Sprint3.Task0.V26.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService dataService = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = dataService.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(1.3446692061935754, res);
        }
    }
}