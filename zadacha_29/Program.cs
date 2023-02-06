// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int large = GetNumber("Введите количество элементов массива: ");
int minimum = GetNumber("Введите минимально возможное значение элемента: ");
int maximum = GetNumber("Введите максимально возможное значение элемента: ");

System.Console.WriteLine("[" + string.Join(", ", GetArray(large, minimum, maximum)) + "]");

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int n, int min, int max)
{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
