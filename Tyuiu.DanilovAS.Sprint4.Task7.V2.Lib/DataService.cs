using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task7.V2.Lib
{
    public class DataService : ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j =0; j < 4; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }
            int result = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        result += matrix[i, j];
                    }
                }
            }
            return result;
        }
    }
}
