using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AbramenkoAS.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 647 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x + 10 > y;
            res[4] = x <= y;
            res[5] = x + 7 >= y;
            return res;
        }
    }
}
