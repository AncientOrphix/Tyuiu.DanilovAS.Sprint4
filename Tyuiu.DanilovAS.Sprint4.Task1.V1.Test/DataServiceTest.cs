using Tyuiu.DanilovAS.Sprint4.Task1.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(res, wait);
        }
    }
}