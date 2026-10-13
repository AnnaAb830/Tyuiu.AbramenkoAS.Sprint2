using Tyuiu.AbramenkoAS.Sprint2.Task7.V1.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление в решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,    *");
            Console.WriteLine("* находится ли точка координатами X,Y в заштрихованной области.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области.");
            }
            
            Console.ReadKey();
        }
    }
}
