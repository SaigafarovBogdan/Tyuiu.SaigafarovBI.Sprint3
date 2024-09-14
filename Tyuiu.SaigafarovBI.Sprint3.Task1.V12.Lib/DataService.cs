using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SaigafarovBI.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0.0;
            for (int i = startValue; i <= stopValue; ++i)
            {
                res += Math.Pow((1 / Math.Pow(i, value)), 2);
            }
            return Math.Round(res, 3);
        }
    }
}
