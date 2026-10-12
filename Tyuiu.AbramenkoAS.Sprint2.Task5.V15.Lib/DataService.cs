using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AbramenkoAS.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            int rimainder = k % 7;
            switch (rimainder)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 0:
                    return "Воскресенье";
                default:
                    return "Ошибка";
            }
        }
    }
}
