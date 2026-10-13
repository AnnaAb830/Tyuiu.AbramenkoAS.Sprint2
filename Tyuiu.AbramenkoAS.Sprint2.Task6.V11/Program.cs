using Tyuiu.AbramenkoAS.Sprint2.Task6.V11.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя сокращенную форму оператора swith,        *");
            Console.WriteLine("* найти дату следующего дня по заданным g(год), m(месяц), n(число).       *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год(невисокостный):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц(от 1 до 12):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число(от 1 до 31):");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n));
            Console.ReadKey();
        }
    }
}
