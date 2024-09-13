using Tyuiu.SaigafarovBI.Sprint3.Task0.V26.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();
            int startValue = 1;
            int endValue = 9;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + dataService.GetMultiplySeries(startValue, endValue));
            Console.ReadKey();
        }
    }
}
