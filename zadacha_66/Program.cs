// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Metka:
System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= m)
{
    System.Console.WriteLine("Нет чисел в промежутке от M до N! Повторите ввод!");
    goto Metka;
}
System.Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + GetSum(m, n, 0));

int GetSum(int numM, int numN, int sum)
{
    if (numN < numM)
    {
        return sum;
    }
    sum += numM;
    return GetSum(numM + 1, numN, sum);
}