// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)


using System; // Подключение пространства имен System для использования стандартных функций

class Program
{
    static void Main()
    {
        // Бесконечный цикл для запроса чисел у пользователя
        while (true)
        {
            // Запрос строки от пользователя
            string input = ReadString("Введите целое число (или 'q' для выхода): ");
            
            // Проверка, если пользователь ввел 'q' (в любом регистре), выйти из цикла
            if (input.ToLower() == "q")
            {
                break;
            }

            // Попытка преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверка, является ли сумма цифр числа четной, если да, выйти из цикла
                if (IsSumOfDigitsEven(number))
                {
                    break;
                }
            }
            else
            {
                // Сообщение пользователю о некорректном вводе
                Console.WriteLine("Некорректный ввод, пожалуйста, введите целое число.");
            }
        }

        // Запрос размера массива у пользователя
        int arraySize = ReadInt("Введите размер массива: ");
        // Генерация массива случайных чисел
        int[] array = GenerateArray(arraySize, 0, 10);
        // Вывод массива на экран
        PrintArray(array);

        // Переворачивание массива
        int[] reversedArray = ReverseArray(array);
        // Вывод перевернутого массива на экран
        PrintArray(reversedArray);
        // Объединение элементов перевернутого массива в строку
        string joinedArray = Join(reversedArray, ", ");
        // Вывод объединенной строки перевернутого массива
        Console.WriteLine("Перевернутый массив: [" + joinedArray + "]");
    }

    // Метод для вывода массива на экран в квадратных скобках
    static void PrintArray(int[] arrayForPrint)
    {
        Console.Write("["); // Вывод открывающей квадратной скобки
        for(int i = 0; i < arrayForPrint.Length; i++)
        {
            if (i > 0) Console.Write(", "); // Добавление запятой перед элементами, кроме первого
            Console.Write(arrayForPrint[i]); // Вывод элемента массива
        }
        Console.WriteLine("]"); // Вывод закрывающей квадратной скобки
    }

    // Метод для генерации массива случайных чисел
    static int[] GenerateArray(int size, int minValue, int maxValue)
    {
        int[] tempArray = new int[size]; // Создание массива заданного размера
        Random rand = new Random(); // Создание объекта для генерации случайных чисел

        // Заполнение массива случайными числами в заданном диапазоне
        for (int i = 0; i < tempArray.Length; i++)
            tempArray[i] = rand.Next(minValue, maxValue);

        return tempArray; // Возврат заполненного массива
    }

    // Метод для запроса целого числа у пользователя
    static int ReadInt(string msg)
    {
        System.Console.Write(msg); // Вывод сообщения для пользователя
        return Convert.ToInt32(Console.ReadLine()); // Чтение и преобразование введенной строки в целое число
    }

    // Метод для запроса строки у пользователя
    static string ReadString(string msg)
    {
        System.Console.Write(msg); // Вывод сообщения для пользователя
        return Console.ReadLine(); // Чтение введенной строки
    }

    // Метод для проверки, является ли сумма цифр числа четной
    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0; // Инициализация суммы цифр
        while (number != 0)
        {
            sum += number % 10; // Добавление последней цифры числа к сумме
            number /= 10; // Удаление последней цифры числа
        }
        return sum % 2 == 0; // Возврат результата проверки четности суммы
    }

    // Метод для объединения элементов массива в строку с заданным разделителем
    static string Join(int[] array, string separator)
    {
        return string.Join(separator, array); // Использование метода string.Join для объединения элементов
    }

    // Метод для переворачивания массива
    static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length]; // Создание нового массива для хранения перевернутого массива
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i]; // Копирование элементов в обратном порядке
        }
        return reversedArray; // Возврат перевернутого массива
    }
}
