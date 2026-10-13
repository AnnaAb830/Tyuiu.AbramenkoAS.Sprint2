using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AbramenkoAS.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g < 1)
            {
                throw new ArgumentException($"Год должен быть натуральным числом. Значение {g}");
            }

            if (m < 1 || m > 12)
            {
                throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            if (n < 1 || n > 31)
            {
                throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
            }
            int nextDay;
            int nextMonth;
            int nextYear;
            int daysInMonth = m switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };
            if (n > daysInMonth)
            {
                throw new ArgumentException($"В {m}-м месяце {daysInMonth} дней. Значение {n} некорректно.");
            }
            if (n < daysInMonth)
            {
                nextDay = n + 1;
                nextMonth = m;
                nextYear = g;
            }
            
            else if (m < 12)
            {
                nextMonth = m + 1;
                nextYear = g;
                nextDay = 1;
             
            }
            else
            {
                nextDay = 1;
                nextMonth = 1;
                nextYear = g + 1;
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}
