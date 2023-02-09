// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

System.Console.Write("Введите количество элементов массива: ");
double[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {GetResult(arr)}");

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

double GetResult(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return Math.Round(max - min, 2);
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}
