// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    PrintResult(n);
}
else
{
    System.Console.WriteLine("Число N меньше единицы!");
}

void PrintResult(int x)
{
    for (int i = 1; i <= x; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
    System.Console.WriteLine();         //добавил чтобы bash был на следующей строке,так красивее 
}

