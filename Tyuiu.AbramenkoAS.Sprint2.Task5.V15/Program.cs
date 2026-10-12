using System.ComponentModel.Design;
using Tyuiu.AbramenkoAS.Sprint2.Task5.V15.Lib;


namespace Tyuiu.AbramenkoAS.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch,                 *");
            Console.WriteLine("* вычисляет, каким днем недели является k-й день невисокостного года,     *");
            Console.WriteLine("* в котором 1 января понедельник.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня(от 1 до 365):");
            int day = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res;
            if ((day < 1) || (day > 365))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это день недели:" + ds.FindDayName(day);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
