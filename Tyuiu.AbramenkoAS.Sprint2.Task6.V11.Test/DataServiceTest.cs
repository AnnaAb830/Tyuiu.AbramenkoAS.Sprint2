using Tyuiu.AbramenkoAS.Sprint2.Task6.V11.Lib;

namespace Tyuiu.AbramenkoAS.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("16.01.2024", ds.FindDateOfNextDay(2024, 1, 15));
            Assert.AreEqual("01.02.2024", ds.FindDateOfNextDay(2024, 1, 31));
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 28));
            Assert.AreEqual("01.05.2024", ds.FindDateOfNextDay(2024, 4, 30));
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}
