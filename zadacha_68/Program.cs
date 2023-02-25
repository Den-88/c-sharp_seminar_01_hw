// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Metka:
int m = ReadInt("M");
int n = ReadInt("N");
if (m < 0 || n < 0)
{
    System.Console.WriteLine("Одно или оба числа отрицательные! Повторите ввод!");
    goto Metka;
}
System.Console.WriteLine("Результат: " + GetAkkerman(m, n));

int ReadInt(string text)
{
    System.Console.Write("Введите неотрицательное число " + text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return GetAkkerman(numM - 1, 1);
    }
    else
    {
        return GetAkkerman(numM - 1, GetAkkerman(numM, numN - 1));
    }
}
