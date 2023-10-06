using System;

class Program
{
    static void FindMinMax(int[] arr, out int minValue, out int maxValue)
    {
        minValue = arr[0];
        maxValue = arr[0];

        for (int i = 1; i < arr.Length; ++i)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть кількість елементів у масиві: ");
        int size = int.Parse(Console.ReadLine());

        int[] myArray = new int[size];
        Random random = new Random(); // Об'єкт для генерації випадкових чисел

        // Заповнення масиву випадковими числами
        for (int i = 0; i < size; ++i)
        {
            myArray[i] = random.Next(1, 101); // Генерувати випадкове число від 1 до 100
        }

        int minValue, maxValue;
        FindMinMax(myArray, out minValue, out maxValue);

        Console.WriteLine($"Масив випадкових чисел:");
        for (int i = 0; i < size; ++i)
        {
            Console.Write($"{myArray[i]} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Найменший елемент: {minValue}");
        Console.WriteLine($"Найбільший елемент: {maxValue}");
    }
}