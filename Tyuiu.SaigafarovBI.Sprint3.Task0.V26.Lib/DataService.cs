using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SaigafarovBI.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1.0;
            for (int i = startValue; i < stopValue; ++i)
            {
                res *= (Math.Pow(2.0, i) / (i + 1.0)) * Math.Cos(1.8);
            }
            return res;
        }
    }
}
