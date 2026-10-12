using Tyuiu.AbramenkoAS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 42;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 1.023;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 54;
            double y = 53;
            double res = ds.Calculate(x, y);
            double wait = 54;
            Assert.AreEqual(wait, res);
        }
    }
}
