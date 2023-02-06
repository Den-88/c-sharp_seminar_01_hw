// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

PrintResult();

int GetNumber(char num_text)
{
    System.Console.Write($"Введите число {num_text}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetResult()
{
    int A = GetNumber('A');
    int B = GetNumber('B');
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

void PrintResult()
{
    System.Console.WriteLine($"Результат: {GetResult()}");
}