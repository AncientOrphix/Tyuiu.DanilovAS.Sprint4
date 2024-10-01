using Tyuiu.DanilovAS.Sprint4.Task1.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. С клавиатуры: 8, 2, 7, 5, 0, 7, 4, 7, 5, 7           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*									                                     *");
            Console.WriteLine("***************************************************************************");

            int[] numsArry = new int[10];

            for(int i = 0; i < numsArry.Length; i++)
            {
                Console.Write($"Введите значение {i} элемента массива: ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for(int i = 0; i < numsArry.Length; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }

            Console.WriteLine();

            


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArry);
            Console.WriteLine($"Ответ: {res}");
            Console.ReadKey();
        }
    }
}
