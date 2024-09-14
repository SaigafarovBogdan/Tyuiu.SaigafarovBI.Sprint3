using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SaigafarovBI.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string res = value;
            foreach (char c in res)
            {
                if (char.IsDigit(c))
                {
                    res = res.Replace(c, item);
                }
            }
            return res;
        }
    }
}
