// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        int count = 0;
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                count++;
        }

        Console.WriteLine($"количество чётных чисел в массиве -> {count}");
    }

    static void FillArrayRandomNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("[" + array[i]);
            }
            else
            {
                Console.Write(", " + array[i]);
            }
        }
        Console.WriteLine("]");
    }
}
