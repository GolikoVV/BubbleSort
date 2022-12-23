using System;

namespace BubbleSort
{
    class Program
    {
        //метод обмена элементов
        static void Swap(ref int a, ref int b) //для определения переменной
        {
            var temp = a;
            a = b;
            b = temp;
        }

        //сортировка пузырьком
        static int[] BubbleSort(int[] array)
        {
            var c = array.Length;
            for (var i = 1; i < c; i++)
            {
                for (var j = 0; j < c - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries); //метод возвращает массив, состоящий из отдельных слов из строки.

            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));

            Console.ReadLine();
        }
    }
}