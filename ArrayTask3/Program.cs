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
            bool isLocalMaximum;
            int oneElement = 1;

            Console.WriteLine("Массив: \n");

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(itemMinValue, itemMaxValue);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arraySize; i++)
            {
                isLocalMaximum = false;

                if (i == 0 && i + oneElement > arraySize - oneElement)
                {
                    isLocalMaximum = true;
                }
                else if (i == 0 && i + oneElement <= arraySize - oneElement)
                {
                    if (array[i] > array[i + oneElement])
                    {
                        isLocalMaximum = true;
                    }        
                } 
                else if (i == arraySize - oneElement && i - oneElement >= 0)
                {
                    if (array[i] > array[i - oneElement])
                    {
                        isLocalMaximum = true;
                    }
                }
                else if (i > 0 && i < arraySize - oneElement)
                {
                    if (array[i] > array[i - oneElement] && array[i] > array[i + oneElement])
                    {
                        isLocalMaximum = true;
                    }
                }
                if (isLocalMaximum)
                {
                    Console.WriteLine($"Число {array[i]} индекс массива {i} является локальным максимумом");
                }
            }
        }
    }
}
