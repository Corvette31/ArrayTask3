using System;

namespace ArrayTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 30;
            int itemMinValue = 1;
            int itemMaxValue = 101;
            int[] array = new int[arraySize];


            Console.WriteLine("Массив: \n");

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(itemMinValue, itemMaxValue);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\n");

            if (arraySize >= 2)
            {
                if (array[0] > array[1])
                {
                    Console.WriteLine($"Число {array[0]} индекс массива {0} является локальным максимумом");
                }
                if (array[arraySize - 1] > array[arraySize - 2])
                {
                    Console.WriteLine($"Число {array[arraySize - 1]} индекс массива {arraySize - 1} является локальным максимумом");
                }
            }

            for (int i = 0; i < arraySize; i++)
            {
                if (i == 0 && i + 1 > arraySize - 1)
                {
                    Console.WriteLine($"Число {array[i]} индекс массива {i} является локальным максимумом");
                }
                else if (i > 0 && i < arraySize - 1)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        Console.WriteLine($"Число {array[i]} индекс массива {i} является локальным максимумом");
                    }
                }
            }
        }
    }
}
