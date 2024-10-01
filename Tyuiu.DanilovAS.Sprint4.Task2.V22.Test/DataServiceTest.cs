using Tyuiu.DanilovAS.Sprint4.Task2.V22.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[13] { 3, 4, 2, 1, 2, 4, 5, 3, 4, 4, 5, 2, 1 };
            var res = ds.Calculate(array);
            var wait = 225;
            Assert.AreEqual(res, wait);
        }
    }
}