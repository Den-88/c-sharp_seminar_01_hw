// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введено чисел > 0: " + GetResult(GetNumbers()));

int[] GetNumbers()
{
    System.Console.Write("Введите целые числа через пробел: ");
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int GetResult(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}