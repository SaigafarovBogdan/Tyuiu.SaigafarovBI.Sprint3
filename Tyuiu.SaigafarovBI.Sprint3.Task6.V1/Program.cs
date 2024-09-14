using Tyuiu.SaigafarovBI.Sprint3.Task6.V1.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();
            int startValue = 11;
            int endValue = 17;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + endValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей = " + dataService.GetSumTheDivisors(startValue, endValue));

            Console.ReadKey();
        }
    }
}
