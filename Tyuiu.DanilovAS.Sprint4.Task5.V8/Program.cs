using Tyuiu.DanilovAS.Sprint4.Task5.V8.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -3 до 4. Заменить отрицательные    *");
            Console.WriteLine("* элементы на 0.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*									      *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];

            for(int i = 0; i<5; i++)
            {
                for(int j =0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-3,4);
                }
            }

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine();

                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i},{j}] = {array[i,j]}\t|\t");
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] arrayRes = ds.Calculate(array);
            Console.WriteLine("Ответ равен:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i},{j}] = {arrayRes[i, j]}\t|\t");
                }
            }

            Console.ReadKey();

        }
    }
}
