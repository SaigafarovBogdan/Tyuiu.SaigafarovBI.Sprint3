using Tyuiu.SaigafarovBI.Sprint3.Task4.V16.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Assert.AreEqual(6.719, dataService.Calculate(startValue,stopValue));
        }
    }
}