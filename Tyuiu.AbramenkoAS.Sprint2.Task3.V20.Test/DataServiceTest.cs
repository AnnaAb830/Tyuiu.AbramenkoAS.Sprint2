using Tyuiu.AbramenkoAS.Sprint2.Task3.V20.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.750;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}
