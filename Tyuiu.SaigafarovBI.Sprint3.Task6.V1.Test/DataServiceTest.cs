using Tyuiu.SaigafarovBI.Sprint3.Task6.V1.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService dataService = new DataService();
            int startValue = 11;
            int stopValue = 17;
            Assert.AreEqual(151,dataService.GetSumTheDivisors(startValue,stopValue));
        }
    }
}