using Tyuiu.SaigafarovBI.Sprint3.Task3.V21.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "12812=8 kf1=k2 1929";
            Assert.AreEqual("eeeee=e kfe=ke eeee", ds.ReplaceNumOnChar(str, 'e'));
        }
    }
}