using Tyuiu.AbramenkoAS.Sprint2.Task3.V20.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные оператолы if-else                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
            Console.WriteLine("* Результат округлить до 3 знаков после запятой.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = "+ res);
            Console.ReadKey();
        }
    }
}
