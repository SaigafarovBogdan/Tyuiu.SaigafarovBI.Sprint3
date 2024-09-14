using Tyuiu.SaigafarovBI.Sprint3.Task3.V21.Lib;
namespace Tyuiu.SaigafarovBI.Sprint3.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();
            string str = "12812=8 kf1=k2 1929";
            char chr = 'e';

            Console.WriteLine("Исходная строка = " + str);
            Console.WriteLine("Искомый символ = " + chr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Конечная строка = " + dataService.ReplaceNumOnChar(str,chr));

            Console.ReadKey();
        }
    }
}
