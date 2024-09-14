using Tyuiu.SaigafarovBI.Sprint3.Task1.V12.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService dataService = new DataService();
            int value = 5;
            int startValue = 1;
            int endValue = 10;
            Assert.AreEqual(1.001, dataService.GetSumSeries(value, startValue, endValue));
        }
    }
}