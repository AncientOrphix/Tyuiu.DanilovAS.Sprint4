using Tyuiu.DanilovAS.Sprint4.Task7.V2.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] array = new int[rows, columns];
            string str = "597643158942";
            var res = ds.Calculate(rows, columns, str);
            var wait = 39;
            Assert.AreEqual(res, wait);
        }
    }
}