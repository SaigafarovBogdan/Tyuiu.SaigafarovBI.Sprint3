using Tyuiu.SaigafarovBI.Sprint3.Task2.V20.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService dataService = new DataService();
            int value = 1;
            int startValue = 1;
            int endValue = 6;
            Assert.AreEqual(914700.94, dataService.GetMultiplySeries(value, startValue, endValue));
        }
    }
}