using Tyuiu.AbramenkoAS.Sprint2.Task7.V1.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.3, 0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.5, -0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.5, 0.3));
        }
    }
}
