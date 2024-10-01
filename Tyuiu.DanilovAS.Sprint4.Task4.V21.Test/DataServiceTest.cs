using Tyuiu.DanilovAS.Sprint4.Task4.V21.Lib;


namespace Tyuiu.DanilovAS.Sprint4.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
{
                {3,6,4,6,6},
                {7,5,5,5,8},
                {8,3,6,7,7},
                {5,3,8,4,5},
                {3,7,4,3,8}     };

            var wait = 68;
            var res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}