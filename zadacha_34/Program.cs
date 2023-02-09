// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

System.Console.Write("Введите количество элементов массива: ");
int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
System.Console.WriteLine($"Количество чётных чисел в массиве: {GetCountEven(arr)}");

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

int GetCountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

