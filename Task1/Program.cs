// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа 
// завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.


using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string input = ReadString("Введите целое число (или 'q' для выхода): ");
            
            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, пожалуйста, введите целое число.");
            }
        }

        int arraySize = ReadInt("Введите размер массива: ");
        int[] array = GenerateArray(arraySize, 0, 10);
        PrintArray(array);
        string joinedArray = Join(array, ", ");
        Console.WriteLine("Объединенный массив: " + joinedArray);
    }

    static void PrintArray(int[] arrayForPrint)
    {
        for(int i = 0; i < arrayForPrint.Length; i++)
            System.Console.Write(arrayForPrint[i] + " ");

        System.Console.WriteLine();
    }

    static int[] GenerateArray(int size, int minValue, int maxValue)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i = 0; i < tempArray.Length; i++)
            tempArray[i] = rand.Next(minValue, maxValue);

        return tempArray;
    }

    static int ReadInt(string msg)
    {
        System.Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }

    static string ReadString(string msg)
    {
        System.Console.Write(msg);
        return Console.ReadLine();
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }

    static string Join(int[] array, string separator)
    {
        return string.Join(separator, array);
    }
}
