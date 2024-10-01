using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows =array.GetUpperBound(0)+1 ;//количество строк
            int columns = array.Length / rows; //количество столбцов
            int minElement = array[0, 3];

            for(int i = 0; i<rows; i++)//строка
            {
                if (array[i,3] < minElement)
                {
                    minElement = array[i, 3];
                }
            }

            return minElement ;

        }
    }
}
