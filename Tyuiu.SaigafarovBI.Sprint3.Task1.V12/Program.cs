using Tyuiu.SaigafarovBI.Sprint3.Task1.V12.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();
            int value = 5;
            int startValue = 1;
            int endValue = 10;

            Console.WriteLine("Переменная N: "+ value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + dataService.GetSumSeries(value,startValue, endValue));

            Console.ReadKey();
        }
    }
}
