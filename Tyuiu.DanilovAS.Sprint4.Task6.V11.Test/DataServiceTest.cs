using Tyuiu.DanilovAS.Sprint4.Task6.V11.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int wait = 3;
            var res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}