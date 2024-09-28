using Tyuiu.DanilovAS.Sprint4.Task0.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = {6,4,3,2,1,0,9,8,7,5 };
            int wait = 20;
            var res = ds.GetSumEvenArrEl(numsArray);
             
            Assert.AreEqual(res, wait);
        }
    }
}