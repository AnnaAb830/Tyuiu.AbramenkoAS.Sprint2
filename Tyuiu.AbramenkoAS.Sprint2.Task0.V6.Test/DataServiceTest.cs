using Tyuiu.AbramenkoAS.Sprint2.Task0.V6.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
