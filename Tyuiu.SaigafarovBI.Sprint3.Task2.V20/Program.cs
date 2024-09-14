using Tyuiu.SaigafarovBI.Sprint3.Task2.V20.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task2.V20
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
            int endValue = 6;
            int value = 1;

            Console.WriteLine("Значение переменной X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + dataService.GetMultiplySeries(value,startValue, endValue));

            Console.ReadKey();
        }
    }
}
